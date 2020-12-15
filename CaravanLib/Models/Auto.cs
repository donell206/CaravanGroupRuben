using CaravanLib.Interfaces;
using System;
using CaravanLib.Exceptions;

namespace CaravanLib.Models
{
    public class Auto : Eigendom, IVoertuig, ITrekker
    {
        #region PROPERTIES
        public int MaximumSnelheid { get; set; }
        public string Merk { get; set; }
        public int Snelheid { get; private set; }
        public ITrekbaar AanhangWagen { get; private set; }
        public int MaximaalTrekGewicht { get; set; }
        public int AantalBanden { get; set; }
        public int Gewicht { get; set; }
        #endregion
        #region CONSTRUCTORS
        public Auto(int maximumSnelheid, string merk, ITrekbaar aanhangWagen, int maximaalTrekGewicht, int aantalBanden, int gewicht, string eigenaar, double prijs) : base(eigenaar, prijs)
        {
            MaximumSnelheid = maximumSnelheid;
            Merk = merk;
            Snelheid = 0;
            AanhangWagen = aanhangWagen;
            MaximaalTrekGewicht = maximaalTrekGewicht;
            AantalBanden = aantalBanden;
            Gewicht = gewicht;
        }
        #endregion
        #region METHODS 
        /// <summary>
        /// Geeft de class Auto een geformatteerde string
        /// </summary>
        /// <returns>ToString</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nMerk: {Merk}\nMaximumSnelheid: {MaximumSnelheid}\nSnelheid: {Snelheid}\nAanhangwagen:\n{AanhangWagen}\nMaximaalTrekGewicht: {MaximaalTrekGewicht}\nAantalBanden: {AantalBanden}\nGewicht: {Gewicht} ";
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
        /// Koppelt de aanhangwagen aan de auto
        /// </summary>
        /// <param name="aanhangwagen"></param>
        public void KoppelAanhangwagen(ITrekbaar aanhangwagen)
        {
            if (Snelheid != 0)
            {
                KoppelException ke = new KoppelException(Snelheid);
                throw new Exception(ke.Message);
            }
            else
            {
                if (Gewicht + aanhangwagen.Gewicht > MaximaalTrekGewicht)
                {
                    OverBeladenException oe = new OverBeladenException(MaximaalTrekGewicht, aanhangwagen.Gewicht);
                    throw new Exception(oe.Message);
                }
                else
                {
                    AanhangWagen = aanhangwagen;
                }
            }
        }
        #endregion 
    }
}
