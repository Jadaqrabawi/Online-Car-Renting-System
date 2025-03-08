using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RoyalCarRentalSystem.Models
{
    public partial class RoyalCarDataEntities : DbContext
    {
        public RoyalCarDataEntities()
            : base("name=RoyalCarDataEntities")
        {
        }

        public virtual DbSet<BookingData> BookingDatas { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<PassengerData> PassengerDatas { get; set; }
    }
}