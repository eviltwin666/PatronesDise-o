﻿using System;
namespace Laboratorio8._8_Puente
{
    class Customers : CustomersBase

    {
        // Constructor

        public Customers(string group)
          : base(group)
        {
        }

        public override void ShowAll()
        {
            // Add separator lines

            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}