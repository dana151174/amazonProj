using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDana
{
    internal class Item
    {
        private string title;
        private string price;
        private string link;

        public Item( string title, string price, string link)
        {
            this.title = title;
            this.price = price;
            this.link = link;
        }
    }

}
