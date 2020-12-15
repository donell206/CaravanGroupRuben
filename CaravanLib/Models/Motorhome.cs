using System;
using CaravanLib.Interfaces;

namespace CaravanLib.Models
{
    public class Motorhome : Auto, IBewoonbaar
    {
        public int AantalSlaapkamers { get; private set; }
        private int _bewoonbaarOppervlakte;

        public int BewoonbaarOppervlakte
        {
            get { return _bewoonbaarOppervlakte; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Het bewoonbare oppervlakte mag niet kleiner dan 0 zijn");
                }
                else
                {
                    _bewoonbaarOppervlakte = value;
                }
            }
        }
        #region PROPERTIES
        #endregion
        #region CONSTRUCTORS
        public Motorhome(int bewoonbaarOppervlakte,int maximumsnelheid,string merk,ITrekbaar aanhangwagen,int maximaalTrekGewicht, int aantalBanden, int gewicht, string eigenaar, double prijs) : base(maximumsnelheid,merk,aanhangwagen,maximaalTrekGewicht,aantalBanden,gewicht,eigenaar, prijs)
        {
            AantalSlaapkamers = 1;
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
            return base.ToString() + $"\nAantal slaapkamers: {AantalSlaapkamers}\nBewoonbaar oppervlakte: {BewoonbaarOppervlakte}M²";
        }
        #endregion
    }
}
