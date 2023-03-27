using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2
{
    internal class Clothes
    {
        private string brand;
        private string style;
        private int price;

        public string Brand
        {
            get { return brand; }   
            set { brand = value; }
        }
        public string Style
        {
            get { return style; }   
            set { style = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }


        public Clothes()
        {
            brand = "";
            style = "";
            price = 0;
        }
      
        public Clothes(string brand, string style, int price)
        {
            this.brand = brand;
            this.style = style;
            this.price = price;
        }

        public override string ToString()
        {
            return "Бренд: " + brand + ",Стиль: " + style + ", Цена: " + price;
        }


    }
}
