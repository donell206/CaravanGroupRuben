using System;

namespace CaravanLib.Models
{
    public class Kasteel : Huis
    {
        #region PROPERTIES
        private int _aantalSlaapkamers;
        public override int AantalSlaapkamers
        {
            get { return _aantalSlaapkamers; }
            set 
            { 
                if(value < 3)
                {
                    Console.WriteLine("Kasteel heeft minimum 3 slaapkamers ");
                }
                else
                {
                    _aantalSlaapkamers = value;
                }
            }
        }
      
        #endregion
        #region CONSTRUCTORS
        public Kasteel(int aantalSlaapkamers, int bewoonbaarOppervlakte,string eigenaar,double prijs):base(aantalSlaapkamers,bewoonbaarOppervlakte,eigenaar,prijs)
        {

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
        #endregion
    }
}
