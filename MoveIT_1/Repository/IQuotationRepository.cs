using System.Collections.Generic;
using MoveIT_1.Models;

namespace MoveIT_1.Repository
{
    public interface IQuotationRepository
    {
        IEnumerable<Quotation> GetAllQuotations();
        Quotation GetQuotation(string id, string userId);
        Quotation AddQuotation(Quotation qoutation);
    }
}