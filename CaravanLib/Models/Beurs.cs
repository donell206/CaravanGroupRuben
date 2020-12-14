using CaravanLib.Interfaces;
using System;

namespace CaravanLib.Models
{
    public class Beurs
    {
        #region PROPERTIES
        IEigendom[] artikels;
        #endregion
        #region CONSTRUCTORS
        public Beurs()
        {
            artikels = new IEigendom[0];
        }
        #endregion
        #region METHODS
        /// <summary>
        /// Bij het toevoegen van een nieuwe eigendom zal de array steeds vergroten
        /// </summary>
        /// <param name="eigendom"></param>
        public void Add(IEigendom eigendom)
        {
            Array.Resize(ref artikels, artikels.Length + 1);
            artikels[artikels.Length - 1] = eigendom;
        }

        /// <summary>
        /// Geeft een lijst Belaadbare objecten
        /// </summary>
        /// <returns>belaadbaar</returns>
        public IBelaadbaar[] GetBelaadbaarLijst()
        {
            IBelaadbaar[] belaadbaar = new IBelaadbaar[artikels.Length];
            int j = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IBelaadbaar belaadbaar1)
                {
                    belaadbaar[j] = belaadbaar1;
                    j++;
                }
            }
            return belaadbaar;
        }

        /// <summary>
        /// Geeft lijst van bewoonbare objecten
        /// </summary>
        /// <returns>bewoonbaar</returns>
        public IBewoonbaar[] GetBewoonbaarLijst()
        {
            IBewoonbaar[] bewoonbaar = new IBewoonbaar[artikels.Length];
            int j = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IBewoonbaar bewoonbaar1)
                {
                    bewoonbaar[j] = bewoonbaar1;
                    j++;
                }
            }
            return bewoonbaar;
        }

        /// <summary>
        /// Geeft lijst van trekbare objecten
        /// </summary>
        /// <returns>trekbaar</returns>
        public ITrekbaar[] GetTrekbaarLijst()
        {
            ITrekbaar[] trekbaar = new ITrekbaar[artikels.Length];
            int j = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is ITrekbaar trekbaar1)
                {
                    trekbaar[j] = trekbaar1;
                    j++;
                }
            }
            return trekbaar;
        }

        /// <summary>
        /// Geeft lijst van trekkende objecten
        /// </summary>
        /// <returns>trekker</returns>
        public ITrekker[] GetTrekkerLijst()
        {
            ITrekker[] trekker = new ITrekker[artikels.Length];
            int j = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is ITrekker trekker1)
                {
                    trekker[j] = trekker1;
                    j++;
                }
            }
            return trekker;
        }

        /// <summary>
        /// Geeft lijst van voertuig objecten
        /// </summary>
        /// <returns>voertuig</returns>
        public IVoertuig[] GetVoertuigLijst() 
        {
            IVoertuig[] voertuig = new IVoertuig[artikels.Length];
            int j = 0;
            for (int i = 0; i < artikels.Length; i++)
            {
                if (artikels[i] is IVoertuig voertuig1)
                {
                    voertuig[j] = voertuig1;
                    j++;
                }
            }
            return voertuig;
        }
        #endregion
    }
}
