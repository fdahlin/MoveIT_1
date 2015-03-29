using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using MoveIT_1.Models;

namespace MoveIT_1.Controllers
{
    public class QuotationsController : ApiController
    {
        private Quotation[] _quotations = {
            new Quotation
            {
                Id = 1,
                DistanceInKm = 5,
                Email = "first@email.net",
                EstimatedPrice = 12000,
                FromCity = "Stockholm",
                FromStreet = "Törnbladsgatan 1",
                LivingArea = 102,
                Name = "Janne Lorentzon",
                PackageingHelp = true,
                PianoMove = false
            },
        };

        public IEnumerable<Quotation> GetAllQuotations()
        {
            return _quotations;
        }

        public IHttpActionResult GetQuotation(int id)
        {
            var quotation = _quotations.FirstOrDefault((q) => q.Id == id);
            if (quotation == null)
            {
                return NotFound();
            }
            return Ok(quotation);
        }
    }
}
