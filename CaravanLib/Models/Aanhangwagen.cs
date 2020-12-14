using System;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Aanhangwagen : Eigendom , ITrekbaar
    {
        #region PROPERTIES
        private int aantalBanden;
        public int AantalBanden
        {
            get { return aantalBanden; }
            set
            {
                if (value < 2)
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
        public Aanhangwagen(int aantalBanden, int gewicht,string eigenaar, double prijs):base(eigenaar, prijs)
        {
            AantalBanden = aantalBanden;
            Gewicht = gewicht;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Geeft de class Aanhangwagen een geformatteerde string
        /// </summary>
        /// <returns>ToString</returns>
        public override string ToString()
        {
            return base.ToString() + $"\naantal banden: {AantalBanden}\ngewicht: {Gewicht}";
        }
        #endregion
    }
}
