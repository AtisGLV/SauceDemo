using Microsoft.Playwright;

namespace SwagLabsDemo.Pages
{
    public class CheckoutOverviewPage
    {
        private readonly IPage _page;

        private ILocator ItemName => _page.Locator(".inventory_item_name");
        private ILocator ItemPrice => _page.Locator(".inventory_item_price");
        private ILocator FinishButton => _page.Locator("#finish");
        private ILocator CancelButton => _page.Locator("#cancel");

        public CheckoutOverviewPage(IPage page)
        {
            _page = page;
        }

        public async Task FinishCheckout()
        {
            await FinishButton.ClickAsync();
        }

        public async Task Cancel()
        {
            await CancelButton.ClickAsync();
        }

        // Assertions
        public async Task<bool> IsItemInCartAsync(string itemName)
        {
            var items = await ItemName.AllTextContentsAsync();
            return items.Contains(itemName);
        }

        public async Task<bool> IsItemPriceVisibleAsync(string itemName)
        {
            var prices = await ItemPrice.AllTextContentsAsync();
            return prices.Contains(itemName);
        }
    }
}
