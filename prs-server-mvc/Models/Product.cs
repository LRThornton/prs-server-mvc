﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prs_server_mvc.Models
{
    public partial class Product
    {
        public Product()
        {
            Requestlines = new HashSet<Requestline>();
        }

        public int Id { get; set; }
        public string PartNbr { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string Photopath { get; set; }
        public int VendorId { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual ICollection<Requestline> Requestlines { get; set; }
    }
}
