using System;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Woonboot :Boot,IBewoonbaar
    {
        #region PROPERTIES
        public int AantalSlaapkamers { get; set; }
        private int _bewoonbaarOppervlakte;

        public int BewoonbaarOppervlakte
        {
            get { return _bewoonbaarOppervlakte; }
            set 
            {
                if (value<=0)
                {
                    Console.WriteLine("De oppervlakte moet groter zijn dan 0");
                }
                else
                {
                    _bewoonbaarOppervlakte = value;
                }
            }
        }

        #endregion
        #region CONSTRUCTORS
        public Woonboot(int aantalSlaapkamers, int bewoonbaarOppvervlakte,int maximumSnelheid,string merk,string eigenaar, double prijs):base(maximumSnelheid,merk,eigenaar,prijs)
        {
            AantalSlaapkamers = aantalSlaapkamers;
            BewoonbaarOppervlakte = bewoonbaarOppvervlakte;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// makes a correct representation of the class
        /// </summary>
        /// <returns>formatted class</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nAantal slaapkamers: {AantalSlaapkamers}\nBewoonbare oppervlakte: {BewoonbaarOppervlakte}";
        }
        #endregion
    }
}
