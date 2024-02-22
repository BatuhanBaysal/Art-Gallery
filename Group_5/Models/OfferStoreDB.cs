using System;
using System.Data.Entity;
using System.Linq;

namespace Group_5.Models
{
    public class OfferStoreDB : DbContext
    {
        
        public OfferStoreDB()
            : base("name=OfferStoreDB")
        {
        }
        public System.Data.Entity.DbSet<Group_5.Models.Offer> Offers { get; set; }
    }
}