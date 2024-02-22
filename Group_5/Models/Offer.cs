using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group_5.Models
{
    public class Offer
    {
        public virtual int OfferID { get; set; }
        public virtual string Name { get; set; }
        public virtual int Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string TitleOfWork { get; set; }
        public virtual decimal Price { get; set; }

    }
}