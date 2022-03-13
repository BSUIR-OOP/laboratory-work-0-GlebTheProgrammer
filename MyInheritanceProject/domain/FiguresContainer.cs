using MyInheritanceProject.Interfaces;
using MyInheritanceProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInheritanceProject.domain
{
    internal class FiguresContainer : IFiguresContainer
    {
        private List<Figure> figures = new List<Figure>();

        public bool AddFigure(Figure figure)
        {
            if (figure == null)
                return false;

            figures.Add(figure);
            return true;
        }

        public bool DeleteFigureByIndex(int index)
        {
            if (index >= Figure.Count)
                return false;

            figures.RemoveAt(index);
            Figure.Count--;
            RewriteIndexes(index);

            return true;
        }

        public bool PrintAllFigures()
        {
            try
            {
                foreach (var figure in figures)
                {
                    Console.WriteLine($"Figure index: {figure.Index}");
                    figure.GetAllFields();
                }
             
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool PrintFigureByIndex(int index)
        {
            if (index >= Figure.Count)
            {
                return false;
            }

            Console.WriteLine($"Figure index: {figures[index].Index}"); // Да-да, пошёл я на*ер
            figures[index].GetAllFields();
            return true;
        }

        private void RewriteIndexes(int indexOfDeletedFigure)
        {
            foreach (var figure in figures)
            {
                if (figure.Index > indexOfDeletedFigure)
                    figure.Index--;
            }
        }
    }
}
