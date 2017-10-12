using PromoPage.Models.PromoDb;
using System.Collections.Generic;

namespace PromoPage.Models
{
    public class PromoData
    {
        public List<SeminarData> Seminars { get; set; }
        public List<Position> Positions { get; set; }
        public ParticipantData Participant { get; set; }
        public bool IsTransactionCommitted { get; set; }
    }
}