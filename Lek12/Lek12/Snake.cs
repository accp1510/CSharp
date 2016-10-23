using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Lek11
{
    public class Snake
    {
        public HeadSection head;
        public LinkedList<Section> sections;
        public Section tail;

        public Snake()
        {
            head = new HeadSection();
            head.X = 500;
            head.Y = 500;
            sections = new LinkedList<Section>();
            sections.AddFirst(head);
            tail = head;
            AddSection();
            AddSection();
            AddSection();
        }

        public void AddSection()
        {
            Section s = new Section(tail);
            s.X = tail.X;
            s.Y = tail.Y;
            sections.AddFirst(s);
            tail = s;
        }

        public void Update()
        {
            foreach (var item in sections)
            {
                item.Update();
            }

        }

        public void Draw(Graphics g)
        {
            foreach (var item in sections)
            {
                item.Draw(g);
            }
        }

        public bool SectionBound()
        {
            foreach (var item in sections)
            {
                if (!(item is HeadSection))
                {
                    if (item.X == head.X && item.Y == head.Y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
