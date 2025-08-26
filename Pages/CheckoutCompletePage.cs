using Microsoft.Playwright; 

namespace SwagLabsDemo.Pages
{
    public class CheckoutCompletePage
    {
        private readonly IPage _page;
        private ILocator ConfirmationHeader => _page.Locator(".complete-header");

        public CheckoutCompletePage(IPage page)
        {
            _page = page;
        }
    
        public async Task IsCheckoutComplete()
        {
            var confirmation = await ConfirmationHeader.TextContentAsync();
            Assert.Equal("Thank you for your order!", confirmation?.Trim());
        }
    }
}
