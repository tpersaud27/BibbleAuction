namespace AuctionService.Entities
{
    // When Auction is live bids can be sent
    // When Auction is finished or reserveNotMet, bids cannot be sent
    public enum Status
    {
        Live,
        Finished,
        ReserveNotMet
    }
}
