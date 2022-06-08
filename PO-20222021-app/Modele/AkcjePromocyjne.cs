using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_20222021_app.Modele
{
    public class AkcjePromocyjne
    {
        public PromotorID PromotorID { get; }
        public DateTime StartTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Lenght => EndTime.Subtract(StartTime);
        public AkcjePromocyjne(PromotorID promotorID, DateTime startTime, DateTime endTime)
        {
            PromotorID = promotorID;
            StartTime = startTime;
            EndTime = endTime;
        }
    }
}
