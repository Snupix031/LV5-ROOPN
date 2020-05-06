using System;
using System.Collections.Generic;
using System.Text;

namespace lv5
{
    class GroupNote : Note
    {
        private List<String> names;

        public GroupNote(string message, ITheme theme) : base(message, theme) { names = new List<String>(); }

        public void insert(String name)
        {

            names.Add(name);


        }
        public void delete(int name)
        {
            names.RemoveAt(name);


        }
        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Names: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);


            foreach (String k in names)
            {

                this.ChangeColor();

                Console.WriteLine(k);

                Console.ResetColor();

            }

        }
    }

}
