using System;
using System.Collections.Generic;
using System.Text;

namespace _14_索引器
{
    class Test
    {

        private string[] name = new string[10];

        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }

    }
}
