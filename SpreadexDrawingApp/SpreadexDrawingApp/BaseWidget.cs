using System;
using System.Collections.Generic;
using System.Text;

namespace SpreadexDrawingApp
{
    public class BaseWidget
    {
        public BaseWidget(WidgetType type)
        {
            Type = type;
        }

        public int XCoOrd { get; set; }
        public int YCoOrd { get; set; }
        public  WidgetType Type { get; }

        public virtual void PrintWidget()
        {
            Console.Out.WriteLine("Unknown Widget");
        }

        protected int CheckNumberIsPositive(int numberToCheck)
        {
            return numberToCheck >= 0 ? numberToCheck : 0;
        }
    }
}
