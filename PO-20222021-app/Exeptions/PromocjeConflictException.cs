using PO_20222021_app.Modele;
using System;

namespace PO_20222021_app.Exeptions
{
    public class PromocjeConflictException : Exception
    {
        public Promocje ExistingPromocje { get; }
        public Promocje IncomingPromocje { get; }

        public PromocjeConflictException(Promocje existingPromocje, Promocje incomingPromocje)
        {
            ExistingPromocje = existingPromocje;
            IncomingPromocje = incomingPromocje;
        }

        public PromocjeConflictException(string message, Promocje existingPromocje, Promocje incomingPromocje) : base(message)
        {
            ExistingPromocje = existingPromocje;
            IncomingPromocje = incomingPromocje;
        }

        public PromocjeConflictException(string message, Exception innerException, Promocje existingPromocje, Promocje incomingPromocje) : base(message, innerException)
        {
            ExistingPromocje = existingPromocje;
            IncomingPromocje = incomingPromocje;
        }
    }
}