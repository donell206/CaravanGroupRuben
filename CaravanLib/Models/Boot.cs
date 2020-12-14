using System;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public abstract class Boot : Eigendom, IVoertuig
    {
        #region PROPERTIES
        public int MaximumSnelheid { get; set; }
        public string Merk { get; set; }
        public int Snelheid { get; private set; }
        #endregion
        #region CONSTRUCTORS
        public Boot(int maximumSnelheid, string merk,string eigenaar,double prijs) :base(eigenaar,prijs)
        {
            MaximumSnelheid = maximumSnelheid;
            Merk = merk;
            Snelheid = 0;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Geeft de class Boot een geformatteerde string
        /// </summary>
        /// <returns>ToString</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nMaximumsnelheid: {MaximumSnelheid}\nMerk: {Merk}\nSnelheid: {Snelheid}";
        }
        /// <summary>
        /// Maximumsnelheid mag niet overschreden worden, indien overschreden wordt snelheid de maximumsnelheid
        /// De snelheid kan niet negatief zijn. Indien negatief, 
        /// </summary>
        /// <param name="versnelling">geeft hoeveel de boot versnelt</param>
        public void Versnel(int versnelling)
        {
            if (versnelling > 0)
            {
                if (Snelheid + versnelling > MaximumSnelheid)
                {
                    Console.WriteLine("Snelheid kan niet hoger zijn dan maximum snelheid");
                    Snelheid = MaximumSnelheid;
                }
                else
                {
                    Snelheid += versnelling;
                }
            }
            else
            {
                Console.WriteLine("Je moet een positieve versnelling geven");
            }
        }
        /// <summary>
        /// Vertraagt de Boot
        /// Als de boot trager gaat dan 0 => staat hij gewoon stil en gaat niet achteruit
        /// </summary>
        /// <param name="vertraging">geeft hoeveel de boot vertraagt</param>
        public void Vertraag(int vertraging)
        {
            if (vertraging > 0)
            {
                if ((Snelheid - vertraging) < 0)
                {
                    Console.WriteLine("Snelheid kan niet lager zijn dan 0");
                    Snelheid = 0;
                }
                else
                {
                    Snelheid -= vertraging;
                }
            }
            else
            {
                Console.WriteLine("Je moet een positieve vertraging geven");
            }
        }
        #endregion
    }
}
