using AutoMapper;
using PromoPage.Interfaces;
using PromoPage.Models;
using PromoPage.Models.PromoDb;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromoPage.Services
{
    public class SeminarService : ISeminarService
    {
        private readonly PromoDb _promoDb;

        public SeminarService(PromoDb promoDb)
        {
            _promoDb = promoDb;
        }

        public PromoData GetPromoData()
        {
            var seminarsData = new List<SeminarData>();

            var seminars = _promoDb.Seminars;
            var cities = _promoDb.Cities;

            foreach (var seminar in seminars)
            {
                var seminarData = Mapper.Map<Seminar, SeminarData>(seminar);

                seminarData.City = cities.Where(city => city.Id == seminar.CityId).Select(a => a.CityName).FirstOrDefault();
                seminarsData.Add(seminarData);
            }

            return new PromoData()
            {
                Seminars = seminarsData,
                Positions = _promoDb.Positions.ToList()
            };
        }

        public bool AddParticipant(ParticipantData Participant)
        {
            bool isTransactionCommitted;
            
            try
            {
                var participant = Mapper.Map<ParticipantData, Participant>(Participant);

                participant.PositionId = _promoDb.Positions.Where(p => p.PositionName == Participant.Position).Select(i => i.Id).First();

                _promoDb.Participants.Add(participant);
                _promoDb.SaveChanges();

                isTransactionCommitted = true;
            }
            catch (Exception ex)
            {
                isTransactionCommitted = false;
            }

            return isTransactionCommitted; 
        }
    }
}