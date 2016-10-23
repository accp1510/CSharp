using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Net.Mail;

namespace Lek10File
{
    [Serializable]
    public class FileDetails
    {
        public string filetype = "";
        public long filesize = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - оптравить 2 - принять");
            if (Console.ReadLine() == "1")
            {
                SendFile();
            }
            else
            {
                ReciveFile();
            }
            
        }
        static void ReciveFile()
        {
            Console.WriteLine("Прием файла");
            //UdpClient - класс отвечает за прием и отправку данных по сети
            UdpClient client = new UdpClient(5001);
            IPEndPoint endPoint = null;
            //Прием данных из сети
            byte[] b = client.Receive(ref endPoint);

            //Получаем из массива байт вернуть отправленный объект FileDetails
            XmlSerializer xml = new XmlSerializer(typeof(FileDetails));
            MemoryStream memStream = new MemoryStream();            
            memStream.Write(b, 0, b.Length);
            memStream.Position = 0;
            StreamReader read = new StreamReader(memStream);
            string str = string.Empty;
            while ((str = read.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
       

            client.Close();
            client = new UdpClient(5001);
            //Получаем сам файл
            b = client.Receive(ref endPoint);
            //Сохраняем файл
            FileStream fs = new FileStream("2.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fs.Write(b,0,b.Length);
            fs.Close();
            memStream.Close();
            client.Close();
            //Открываем файл
            Process.Start("2.txt");
        }
        static void SendFile()
        {
            Console.WriteLine("Отправка файла");
            //IP - адрес удаленной машины, на которую отправляем файл
            IPAddress id = IPAddress.Parse(Console.ReadLine());
            IPEndPoint endPoint = new IPEndPoint(id, 5001);
            FileStream file = new FileStream(Console.ReadLine(), FileMode.Open, FileAccess.Read);

            //Переводим объек с информацией о файле в массив байт
            FileDetails fDetails = new FileDetails();
            fDetails.filesize = file.Length;
            fDetails.filetype = file.Name.Substring(file.Name.Length - 3, 3);
            XmlSerializer xml = new XmlSerializer(typeof(FileDetails));
            MemoryStream memStream = new MemoryStream();
            xml.Serialize(memStream, fDetails);

            memStream.Position = 0;
            byte[] b = new byte[memStream.Length];
            memStream.Read(b, 0, b.Length);
            UdpClient sender = new UdpClient();

            //Отправляем информацию о файле удаленному компьютеру
            sender.Send(b, b.Length, endPoint);
            sender.Close();
            //Приостанавливаем работу нашего приложения на 5 секунд
            Thread.Sleep(5000);
            b = new byte[file.Length];

            //Оправляем сам файл
            file.Read(b, 0, b.Length);

            sender = new UdpClient();
            sender.Send(b, b.Length, endPoint);
            sender.Close();
            file.Close();
            memStream.Close();

            //Классы для работы с почтой (отпавление сообщений)
            //SmtpClient s = new SmtpClient();
            //MailMessage m = new MailMessage();
            //s.Send(m);
            
        }
    }
}
