using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceProject.Models
{
    internal class Circle : Figure //Круг
    {
        protected float Radius { get; set; }
        protected float Diameter { get; set; }
        protected float Area { get; set; }

        public Circle(float radius, float piValue = 3.14f)
        {

            Radius = radius;
            Diameter = 2 * Radius;
            Area = piValue * Radius * Radius;
        }

        public override void GetAllFields()
        {
            Console.WriteLine($"\nCircle fields:\nRadius = {Radius}\nDiameter = {Diameter}\nArea = {Area}\n");
        }
    }
}
