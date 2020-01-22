using System;
using System.Collections.Generic;
using System.Linq;

namespace SpreadexDrawingApp
{
    public static class WidgetPrinter
    {
        public static void PrintRequestList(List<BaseWidget> widgets)
        {
            PrintLines();
            Console.Out.WriteLine("Requested Drawing");
            PrintLines();
            if (widgets.Any())
            {
                foreach (var widget in widgets)
                {
                    widget.PrintWidget();
                }
            }
            else
            {
                Console.Out.WriteLine("No Requested Widgets");
            }
            
            PrintLines();
            Console.In.ReadLine();
        }

        private static void PrintLines()
        {
            var lines = "";
            for (var i = 0; i < 64; i++)
            {
                lines += "-";
            }
            Console.Out.WriteLine(lines);
        }
    }
}
