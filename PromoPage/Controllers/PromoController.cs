using PromoPage.Interfaces;
using PromoPage.Models;
using System.Web.Mvc;

namespace PromoPage.Controllers
{
    public class PromoController : Controller
    {
        private readonly ISeminarService _seminarService;

        public PromoController(ISeminarService seminarService)
        {
            _seminarService = seminarService;
        }

        public ActionResult MainPage(PromoData promo)
        {
            promo = _seminarService.GetPromoData();
            return View(promo);
        }

        public ActionResult AddParticipant(PromoData promo)
        {
            var promoData = _seminarService.GetPromoData();

            promo.Positions = promoData.Positions;
            promo.Seminars = promoData.Seminars;

            if (promo.Participant?.Position == null)
                ModelState.AddModelError("Position", "Укажите должность");

            if (promo.Participant != null && ModelState.IsValid)
            { 
                bool isTransactionCommitted = _seminarService.AddParticipant(promo.Participant);
                promo.IsTransactionCommitted = isTransactionCommitted;
            }

            return View("MainPage", promo);
        }
    }
}