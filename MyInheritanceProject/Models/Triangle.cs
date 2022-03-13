using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceProject.Models
{
    internal class Triangle : Figure // Треугольник
    {
        protected float SideA { get; set; }
        protected float SideB { get; set; }
        protected float SideC { get; set; }
        protected float Perimeter { get; set; }
        protected float Area { get; set; }

        public Triangle(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Perimeter = sideA + sideB + sideC;
            Area = (float)Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - sideA) * ((Perimeter / 2) - sideB) * ((Perimeter / 2) - sideC));
        }
        public override void GetAllFields()
        {
            Console.WriteLine($"\nTriangle fields:\nSide A = {SideA}\nSide B = {SideB}\n" +
                $"Side C = {SideC}\nPerimeter = {Perimeter}\nArea = {Area}\n");
        }
    }
}
