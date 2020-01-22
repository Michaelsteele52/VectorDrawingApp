using System;

namespace SpreadexDrawingApp.Widgets
{
    public class RectangleWidget : BaseWidget
    {
        private int width;
        public int Width
        {
            get => this.width;
            set => this.width = CheckNumberIsPositive(value);
        }
        private int height;
        public int Height
        {
            get => this.height;
            set => this.height = CheckNumberIsPositive(value);
        }

        public RectangleWidget() : base(WidgetType.Rectangle)
        {
        }

        public override void PrintWidget()
        {
            Console.Out.WriteLine($"{Type} ({XCoOrd},{YCoOrd}) width={width} height={height}");
        }
    }
}
