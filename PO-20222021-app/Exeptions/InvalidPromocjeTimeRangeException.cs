using PO_20222021_app.Modele;
using System;

namespace PO_20222021_app.Exeptions
{
    internal class InvalidPromocjeTimeRangeException : Exception
    {
        public Promocje Promocje { get; }

        public InvalidPromocjeTimeRangeException(Promocje promocje)
        {
            Promocje = promocje;
        }
    }
}