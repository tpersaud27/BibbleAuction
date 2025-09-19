using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionService.Entities
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string ImageUrl { get; set; }

        // Nav Properties
        // These are for entity framework to setup the 1 to 1 relationship between Item and Auction entities
        public Auction Auction { get; set; }
        public Guid AudctionId { get; set; }
    }
}
