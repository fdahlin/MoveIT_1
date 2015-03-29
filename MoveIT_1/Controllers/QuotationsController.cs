﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using MoveIT_1.Models;
using MoveIT_1.Repository;

namespace MoveIT_1.Controllers
{
    public class QuotationsController : ApiController
    {
        private static readonly IQuotationRepository _quotations = new QuotationRepository();

        public IEnumerable<Quotation> GetAllQuotations()
        {
            return _quotations.GetAllQuotations().AsQueryable();
        }

        public IHttpActionResult GetQuotation(string id)
        {
            var quotation = _quotations.GetQuotation(id);
            if (quotation == null)
            {
                return NotFound();
            }
            return Ok(quotation);
        }

        public void AddQuotation(Quotation quotation)
        {
            _quotations.AddQuotation(quotation);
        }
    }
}
