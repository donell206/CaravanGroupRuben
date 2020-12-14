using CaravanLib.Interfaces;
using System;

namespace CaravanLib.Models
{
    public class Transportboot : Boot, IBelaadbaar
    {
        #region PROPERTIES    
        public int HuidigeBelading { get; set; }
        public int MaximumLaadgewicht { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Transportboot(int huidigeBelading, int maximumLaadgewicht, int maximumSnelheid, string merk, string eigenaar, double prijs) : base(maximumSnelheid, merk, eigenaar, prijs)
        {
            HuidigeBelading = huidigeBelading;
            MaximumLaadgewicht = maximumLaadgewicht;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Laden (toename gewicht) en controle MaximumLaadgewicht
        /// </summary>
        /// <param name="gewicht"></param>
        public void Laden(int gewicht)
        {
            if (HuidigeBelading > MaximumLaadgewicht)
            {
                Console.WriteLine("Boot Zinkt wegens overbelading");
                Vertraag(Snelheid);
            }
        }
        /// <summary>
        /// Methode om gewicht te lossen    
        /// </summary>
        /// <param name="gewicht"></param>
        public void Lossen(int gewicht)
        {

        }

        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return "TRANSPORTBOOT\n"+base.ToString();
        }
        #endregion
    }
}
