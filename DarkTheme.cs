using System;
using System.Collections.Generic;
using System.Text;

namespace lv5
{
    class DarkTheme : ITheme
    {
        public void SetBackgroundColor()
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        public void SetFontColor()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public string GetHeader(int width)
        {
            return new string('+', width);
        }
        public string GetFooter(int width)
        {
            return new string('_', width);
        }
    }
}

