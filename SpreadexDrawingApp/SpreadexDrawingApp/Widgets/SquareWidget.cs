using System;

namespace SpreadexDrawingApp.Widgets
{
    public class SquareWidget : BaseWidget
    {
        private int size;
        public int Size
        {
            get => this.size;
            set => this.size = CheckNumberIsPositive(value);
        }

        public SquareWidget() : base(WidgetType.Square)
        {
        }

        public override void PrintWidget()
        {
            Console.Out.WriteLine($"{Type} ({XCoOrd},{YCoOrd}) size={size}");
        }
    }
}
