using System;

namespace CaravanLib.Exceptions
{
    public class OverBeladenException : Exception
    {
        #region PROPERTIES
        public int MaximaleTrekkracht { get; set; }
        public int TeTrekkenGewicht { get; set; }
        #endregion
        #region CONSTRUCTORS
        public OverBeladenException(int maximaleTrekkracht, int teTrekkenGewicht)
        {
            MaximaleTrekkracht = maximaleTrekkracht;
            TeTrekkenGewicht = teTrekkenGewicht;
        }
        #endregion
        /// <summary>
        /// Geeft de OverBeladenException een geformatteerde string
        /// </summary>
        #region METHODS
        public override string Message => $"De trekkracht is {MaximaleTrekkracht} en het gewicht van de aanhangwagen bedraagt {TeTrekkenGewicht}";
        #endregion
    }
}
