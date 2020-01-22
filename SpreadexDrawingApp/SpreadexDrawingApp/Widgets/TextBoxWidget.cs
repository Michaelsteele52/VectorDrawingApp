using System;

namespace SpreadexDrawingApp.Widgets
{
    public class TextBoxWidget : BaseWidget
    {
        public string Text { get; set; }

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

        public TextBoxWidget() : base(WidgetType.TextBox)
        {
        }

        public override void PrintWidget()
        {
            Console.Out.WriteLine($"{Type} ({XCoOrd},{YCoOrd}) width={width} height={height} Text=\"{Text}\"");
        }
    }
}
