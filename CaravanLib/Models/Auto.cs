using CaravanLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaravanLib.Models
{
    public class Auto : IVoertuig , ITrekker
    {
        #region PROPERTIES
        public int MaximumSnelheid { get; set; }
        public string Merk { get; set; }
        public int Snelheid  { get;  private set; }
        public ITrekbaar AanhangWagen { get; private set; }
        public int MaximaalTrekGewicht { get; set; }
        public int AantalBanden { get; set; }
        public int Gewicht { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Auto(int maximumSnelheid, string merk,ITrekbaar aanhangWagen,int maximaalTrekGewicht, int aantalBanden, int gewicht)
        {
            this.MaximumSnelheid = maximumSnelheid;
            this.Merk = merk;
            this.Snelheid = 0;
            this.AanhangWagen = aanhangWagen;
            this.MaximaalTrekGewicht = maximaalTrekGewicht;
            this.AantalBanden = aantalBanden;
            this.Gewicht = gewicht;
        }
        public Auto()
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
            return $"Merk: {Merk}\nMaximumSnelheid: {MaximumSnelheid}\nSnelheid: {Snelheid}\nAanhangwagen: {AanhangWagen}\nMaximaalTrekGewicht: {MaximaalTrekGewicht}\nAantalBanden: {AantalBanden}\nGewicht: {Gewicht} ";
        }
        /// <summary>
        /// Versnelt de auto
        /// </summary>
        /// <param name="versnelling"></param>
        public void Versnel(int versnelling)
        {
            if (versnelling > 0)
            {
                if ((Snelheid + versnelling) > MaximumSnelheid)
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
        /// Vertraagt de auto
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="aanhangwagen"></param>
        public void KoppelAanhangwagen(ITrekbaar aanhangwagen)
        {
            if(Snelheid != 0)
            {
                Console.WriteLine("Auto moet stil staan voor aanhangwagen te koppelen.");
            }
            else if(Gewicht + aanhangwagen.Gewicht > MaximaalTrekGewicht)
            {
                throw new Exception("Auto is overbeladen");
            }
            else
            {
                AanhangWagen = aanhangwagen;
            }
        }
        #endregion 
    }
}
