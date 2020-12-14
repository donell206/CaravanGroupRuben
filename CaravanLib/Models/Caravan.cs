using CaravanLib.Interfaces;
using System;

namespace CaravanLib.Models
{
    public class Caravan : Aanhangwagen, IBewoonbaar
    {
        #region PROPERTIES
        public int AantalSlaapkamers { get; private set; }
        private int _bewoonbaarOppervlakte;

        public int BewoonbaarOppervlakte
        {
            get { return _bewoonbaarOppervlakte; }
            set 
            {
                if (value<0)
                {
                    Console.WriteLine("De oppervlakte moet groter dan 0 zijn");
                }
                else
                {
                    _bewoonbaarOppervlakte = value; 
                }
            }
        }
        #endregion
        #region CONSTRUCTORS
        public Caravan(int bewoonbaarOppervlakte, int aantalbanden, int gewicht,string eigenaar,double prijs):base(aantalbanden,gewicht,eigenaar,prijs)
        {
            AantalSlaapkamers = 1;
            BewoonbaarOppervlakte = bewoonbaarOppervlakte;
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Geeft de class Caravan een geformatteerde string
        /// </summary>
        /// <returns>ToString</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nAantal slaapkamers: {AantalSlaapkamers}\nOppervlakte: {BewoonbaarOppervlakte}";
        }
        #endregion
    }
}
