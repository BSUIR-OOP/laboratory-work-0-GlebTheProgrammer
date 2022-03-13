﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceProject.Models
{
    internal class Square : LineSegment // Квадрат
    {
        protected float Width { get; set; }
        protected float Perimeter { get; set; }
        protected float Area { get; set; }  // Площадь


        public Square(float side) : base(side)
        {
            Width = Length;
            Perimeter = 4 * Width;
            Area = side * side;
        }

        public override void GetAllFields()
        {
            Console.WriteLine($"\nSquare fields:\nLength = {Length}\nWidth = {Width}\nPerimeter = {Perimeter}\n" +
                $"Area = {Area}\n");
        }
    }
}
