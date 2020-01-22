using System;

namespace SpreadexDrawingApp.Widgets
{
    public class EllipseWidget: BaseWidget
    {
        private int horizontalDiameter;
        public int HorizontalDiameter
        {
            get => this.horizontalDiameter;
            set => this.horizontalDiameter = CheckNumberIsPositive(value);
        }

        private int verticalDiameter;
        public int VerticalDiameter
        {
            get => this.verticalDiameter;
            set => this.verticalDiameter = CheckNumberIsPositive(value);
        }

        public EllipseWidget() : base(WidgetType.Ellipse)
        {
        }

        public override void PrintWidget()
        {
            Console.Out.WriteLine($"{Type} ({XCoOrd},{YCoOrd}) diameterH = {horizontalDiameter} diameterV = {verticalDiameter}");
        }
    }
}
