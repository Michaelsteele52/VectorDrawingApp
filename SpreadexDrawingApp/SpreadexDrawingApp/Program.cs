using System;
using System.Collections.Generic;
using SpreadexDrawingApp.Widgets;

namespace SpreadexDrawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var requestedWidgets = new List<BaseWidget>();

            var rectangle = new RectangleWidget()
            {
                XCoOrd = 10,
                YCoOrd = 10,
                Height = 30,
                Width = 40
            };
            var square = new SquareWidget()
            {
                XCoOrd = 15,
                YCoOrd = 30,
                Size = 35
            };
            var ellipse = new EllipseWidget()
            {
                XCoOrd = 100,
                YCoOrd = 150,
                HorizontalDiameter = -300,
                VerticalDiameter = 200
            };
            var circle = new CircleWidget()
            {
                XCoOrd = 1,
                YCoOrd = 1,
                Size = 300
            };
            var textBox = new TextBoxWidget()
            {
                XCoOrd = 5,
                YCoOrd = 5,
                Width = 200,
                Height = 100,
                Text = "sample text"
            };
            
            requestedWidgets.Add(rectangle);
            requestedWidgets.Add(square);
            requestedWidgets.Add(ellipse);
            requestedWidgets.Add(circle);
            requestedWidgets.Add(textBox);
            
            WidgetPrinter.PrintRequestList(requestedWidgets);
        }
    }
}
