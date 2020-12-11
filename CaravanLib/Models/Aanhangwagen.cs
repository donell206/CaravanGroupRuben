using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Aanhangwagen : ITrekbaar
    {
        #region PROPERTIES
        private int aantalBanden;
        public int AantalBanden
        {
            get { return aantalBanden; }
            set
            {
                if (AantalBanden < 2)
                {
                    Console.WriteLine("Je hebt minstens 2 banden nodig");
                }
                else
                {
                    aantalBanden = value;
                }
            }
        }
        private int gewicht;
        public int Gewicht
        {
            get { return gewicht; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Het gewicht kan niet negatief zijn.");
                }
                else
                {
                    gewicht = value;
                }
            }
        }

        #endregion
        #region CONSTRUCTORS
        public Aanhangwagen()
        {
        }
        public Aanhangwagen(int aantalBanden, int gewicht) 
        {
            AantalBanden = aantalBanden;
            Gewicht = gewicht;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return $"aantal banden: {AantalBanden}\ngewicht: {Gewicht}";
        }
        #endregion
    }
}
