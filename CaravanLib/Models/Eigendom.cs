using System;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public abstract class Eigendom : IEigendom
    {
        #region PROPERTIES
        public string Eigenaar { get; private set; }
        public double Prijs { get; private set; }
        #endregion
        #region CONSTRUCTORS
        public Eigendom(string eigenaar, double prijs)
        {
            VerkoopAan(eigenaar);
            BepaalPrijs(prijs);
        }
        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return $"Eigenaar: {Eigenaar}\nPrijs: €{Prijs}";
        }

        /// <summary>
        /// Bepaalt nieuwe prijs, prijs kan niet negatief zijn
        /// </summary>
        /// <param name="nieuwePrijs"></param>
        public void BepaalPrijs(double nieuwePrijs)
        {
            if (nieuwePrijs < 0)
            {
                Console.WriteLine("Prijs kan niet negatief zijn");
            }
            else
            {
                Prijs = nieuwePrijs;
            }
        }

        /// <summary>
        /// Bepaalt nieuwe eigenaar
        /// </summary>
        /// <param name="nieuweEigenaar"></param>
        public void VerkoopAan(string nieuweEigenaar)
        {
            Eigenaar = nieuweEigenaar;
        }
        /// <summary>
        /// compares object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            return Prijs.CompareTo((obj as IEigendom).Prijs);
        }
        #endregion
    }
}
