using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Boot : IVoertuig
    {
        #region PROPERTIES
        public int MaximumSnelheid { get; set; }
        public string Merk { get; set; }
        public int Snelheid { get; private set; }

        #endregion
        #region CONSTRUCTORS
        public Boot(int maximumSnelheid, string merk):this()
        {
            MaximumSnelheid = maximumSnelheid;
            Merk = merk;
        }
        public Boot()
        {
            Snelheid = 0;
        }


        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary>
        /// Maximumsnelheid mag niet overschreden worden, indien overschreden wordt snelheid de maximumsnelheid
        /// De snelheid kan niet negatief zijn. Indien negatief, 
        /// </summary>
        /// <param name="versnelling"></param>
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
                Console.WriteLine ("Je moet een positieve versnelling geven");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vertraging"></param>
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
