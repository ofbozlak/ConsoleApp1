﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;
        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockControlEvent;
        public string ProductName { get; set; }
        public int Stock { 
            get { return _stock; }
            set
            {
                _stock = value;
                if (value<=15 && StockControlEvent != null)
                {
                    StockControlEvent();
                }
            }
        }

        public void Sell(int amout)
        {
            Stock -= amout;
            Console.WriteLine("{1}-->Stock amout: {0}",Stock,ProductName);
        }
    }
}
