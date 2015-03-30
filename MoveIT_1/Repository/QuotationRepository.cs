using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MoveIT_1.Models;

namespace MoveIT_1.Repository
{
    public class QuotationRepository : IQuotationRepository
    {
        private readonly MongoCollection<Quotation> _quotations;

        public QuotationRepository(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                connectionString = "mongodb://localhost:27017";
            }
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase("Quotations");
            _quotations = database.GetCollection<Quotation>("quotations");

            _quotations.RemoveAll();
            // Add some initial data
            for (int index = 1; index < 5; index++)
            {
                var quotation = new Quotation()
                {
                    DistanceInKm = 10 * index,
                    Email = string.Format("test{0}@example.com", index),
                    Name = string.Format("test{0}", index),
                };
                AddQuotation(quotation);
            }

        }

        public QuotationRepository()
            : this(string.Empty)
        {
        }


        public IEnumerable<Quotation> GetAllQuotations()
        {
            return _quotations.FindAll();
        }


        public Quotation GetQuotation(string id, string userId)
        {
            var query = Query.And(Query<Quotation>.EQ(e => e.Id, id),
                            Query<Quotation>.EQ(e => e.Email, userId));
            return _quotations.FindOne(query);
        }

        public Quotation AddQuotation(Quotation qoutation)
        {
            qoutation.Id = ObjectId.GenerateNewId().ToString(); // TODO: Add calculation
            qoutation.GetPrice();
            qoutation.LastModified = DateTime.UtcNow;
            _quotations.Insert(qoutation);
            return qoutation;
        }
    }
}