﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DeliveryHW_03
{
    public class Product
    {


        private Guid _id => Guid.NewGuid();
        public Guid Id;

        private List<string> _name = new List<string>();
        public List<string> Name
        {
            get
            {
                return _name;
            }
            set
            {
                foreach (var item in value) // Почему здесь используем цикл, а в Персоне не использовали.
                {
                    if (!Regex.IsMatch(item, @"^[a-zA-Z]+$"))
                    {
                        throw new ArgumentException("Должны быть только буквы");
                    }
                }
                _name = value;

            }
        }
        private decimal _price;
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Цена не может быть отрицательной");
                }
                _price = value;
            }
        }

    }
}
