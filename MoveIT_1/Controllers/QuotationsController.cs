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

        public IEnumerable<Quotation> GetAllQuotations()
        {
            return Quotations.GetAllQuotations().AsQueryable();
        }

        public IHttpActionResult GetQuotation(string id)
        {
            var quotation = Quotations.GetQuotation(id);
            if (quotation == null)
            {
                return NotFound();
            }
            return Ok(quotation);
        }

        public IHttpActionResult AddQuotation(Quotation quotation)
        {
            var item = Quotations.AddQuotation(quotation);
            return Ok(item);
        }
    }
}
