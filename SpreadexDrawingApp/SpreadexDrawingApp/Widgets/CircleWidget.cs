using System;

namespace SpreadexDrawingApp.Widgets
{
    class CircleWidget : BaseWidget
    {
        private int size;
        public int Size
        {
            get => this.size;
            set => this.size = CheckNumberIsPositive(value);
        }

        public CircleWidget() : base(WidgetType.Circle)
        {
        }

        public override void PrintWidget()
        {
            Console.Out.WriteLine($"{Type} ({XCoOrd},{YCoOrd}) size={Size}");
        }
    }
}
