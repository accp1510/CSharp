using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lek8DelEvents
{
    public delegate void Display(int m);

    class Account
    {
        public event Display PositionAdd;
        public event Display PositionSub;
        public event Display PositionErr;
        public int Position { get; private set; }

        public void UpdatePosition(int money)
        {
            if (money > 0)
            {
                if (PositionAdd != null)
                {
                    PositionAdd(money);
                }
            }
            if (money < 0 && money + Position < 0)
            {
                if (PositionErr != null)
                {
                    PositionErr(money);
                }
                return;
            }
            if (money < 0)
            {
                if (PositionSub != null)
                {
                    PositionSub(money);
                }
            }

            Position += money;
        }

    }
}
