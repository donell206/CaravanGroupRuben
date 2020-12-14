using System;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Huis : Eigendom, IBewoonbaar
    {
        #region PROPERTIES
        private int _aantalSlaapkamers;
        public virtual int AantalSlaapkamers
        {
            get { return _aantalSlaapkamers; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Deze waarde moet groter zijn dan 0.");
                }
                else
                {
                    _aantalSlaapkamers = value;
                }
            }
        }

        private int _bewoonbaarOppervlakte;
        public int BewoonbaarOppervlakte
        {
            get { return _bewoonbaarOppervlakte; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Deze waarde moet groter zijn dan 0.");
                }
                else
                {
                    _bewoonbaarOppervlakte = value;
                }
            }
        }
        #endregion
        #region CONSTRUCTORS

        public Huis(int aantalSlaapkamers, int bewoonbaarOppervlakte, string eigenaar,double prijs) :base(eigenaar,prijs)
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }

        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>

        public override string ToString()
        {
            return base.ToString() + $"\nAantal slaapkamers: {AantalSlaapkamers}\nOppervlakte: {BewoonbaarOppervlakte}";
        }
        #endregion
    }
}
