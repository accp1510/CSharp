using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek81
{
    partial class Car
    {
        public string Model { get; set; }
        public ColorCar Color { get; set; }
    }
    public enum ColorCar
    {
        Red=4, Black, Blue=9
    }
}
