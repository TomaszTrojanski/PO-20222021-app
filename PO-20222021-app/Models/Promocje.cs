using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class Promocje
    {
        public PromotorID PromotorID { get; }
        public string Username { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Lenght => EndTime.Subtract(StartTime);
        public Promocje(PromotorID promotorID,string Username, DateTime startTime, DateTime endTime)
        {
            PromotorID = promotorID;
            StartTime = startTime;
            EndTime = endTime;
        }

        internal bool Conflicts(Promocje promocje)
        {
            if(promocje.PromotorID != PromotorID)
            {
                return false;
            }
            return promocje.StartTime < EndTime || promocje.EndTime > promocje.StartTime;
        }
    }
}
