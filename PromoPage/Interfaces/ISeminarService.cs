using PromoPage.Models;

namespace PromoPage.Interfaces
{
    public interface ISeminarService
    {
        PromoData GetPromoData();
        bool AddParticipant(ParticipantData Participant);
    }
}