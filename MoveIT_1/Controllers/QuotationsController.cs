using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MoveIT_1.Models;
using MoveIT_1.Repository;

namespace MoveIT_1.Controllers
{
    public class QuotationsController : ApiController
    {
        private static readonly IQuotationRepository Quotations = new QuotationRepository();

        [Authorize]
        public IEnumerable<Quotation> GetAllQuotations()
        {
            return Quotations.GetAllQuotations().AsQueryable();
        }

        [Authorize]
        public IHttpActionResult GetQuotation(string id)
        {
            var quotation = Quotations.GetQuotation(id, User.Identity.Name); //TODO: Kanske fixa till bättre id?
            if (quotation == null)
            {
                return NotFound();
            }
            return Ok(quotation);
        }

        [Authorize]
        public IHttpActionResult AddQuotation(Quotation quotation)
        {
            quotation.Email = User.Identity.Name;
            var item = Quotations.AddQuotation(quotation);
            return Ok(item);
        }
    }
}
