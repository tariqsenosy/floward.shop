using Floward.Shop.Task.Services.CardService.Domain.Entites;
using Floward.Shop.Task.Services.CardService.Domain.Repositories.Implementation;
using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Floward.Task.Card.Tests
{
    public class CardRepositoryTest
    {
        [Fact]
        public void GetCard_Returns_Correct_List_Of_Items()
        {
            CardRepository _rep = new CardRepository();
            Cart _cart =  _rep.GetCart("TariqSenosy").Result;
            Assert.Equal(2, _cart.Items.Count());

        }
        [Fact]
        public void DeleteCard_Returns_Correct_List_Of_ZeroItems()
        {
            CardRepository _rep = new CardRepository();
            bool isDeleted = _rep.DeleteCart("TariqSenosy").Result;
            Assert.True(isDeleted);

        }

    }
}
