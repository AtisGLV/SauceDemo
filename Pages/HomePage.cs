using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SwagLabsDemo.Pages
{
    public class HomePage
    {
        private readonly IPage _page;
        private ILocator Tshirt => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Bolt T-Shirt" });
        private ILocator Backpack => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Sauce Labs Backpack" });
        private ILocator BikeLight => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Bike Light" });
        private ILocator FleeceJacket => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Fleece Jacket" });
        private ILocator Onesie => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Onesie" });
        private ILocator TshirtRed => _page.Locator(".inventory_item_name", new PageLocatorOptions { HasTextString = "Sauce Labs Test.allTheThings() T-Shirt (Red)" });
        private ILocator ShoppingCartButton => _page.Locator(".shopping_cart_link");

        public HomePage(IPage page)
        {
            _page = page;
        }

        public async Task GoToItemTshirt()
        {
            await Tshirt.ClickAsync();
        }

        public async Task GoToItemBackpack()
        {
            await Backpack.ClickAsync();
        }
        public async Task GoToItemBikeLight()
        {
            await BikeLight.ClickAsync();
        }

        public async Task GoToItemFleeceJacket()
        {
            await FleeceJacket.ClickAsync();
        }

        public async Task GoToItemOnesie()
        {
            await Onesie.ClickAsync();
        }

        public async Task GoToItemTshirtRed()
        {
            await TshirtRed.ClickAsync();
        }

        public async Task GoToShoppingCart()
        {
            await ShoppingCartButton.ClickAsync();
        }
        
    }
}
