using AuctionService.Entities;

namespace AuctionService.UnitTests.Entities;

public class AuctionEntityTests
{
    [Fact(DisplayName = "HasReservePrice - Should return true when ReservePrice is greater than zero")]
    public void HasReservePrice_ReservePriceGtZero_True()
    {
        // arrange
        var auction = new Auction { Id = Guid.NewGuid(), ReservePrice = 10 };

        // act
        var result = auction.HasReservePrice();

        // assert
        Assert.True(result);
    }

    [Fact(DisplayName = "HasReservePrice - Should return false when ReservePrice is zero")]
    public void HasReservePrice_ReservePriceIsZero_False()
    {
        // arrange
        var auction = new Auction { Id = Guid.NewGuid(), ReservePrice = 0 };

        // act
        var result = auction.HasReservePrice();

        // assert
        Assert.False(result);
    }
}