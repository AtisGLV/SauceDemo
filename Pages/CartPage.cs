using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SwagLabsDemo.Pages
{
    public class CartPage
    {
        private readonly IPage _page;

        // Define locators
        private ILocator CheckoutButton => _page.Locator("#checkout");

        public CartPage(IPage page)
        {
            _page = page;
        }

        // Actions
        public async Task GoToCheckoutAsync()
        {
            await CheckoutButton.ClickAsync();
        }
    }
}
