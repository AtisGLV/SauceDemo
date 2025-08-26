using Microsoft.Playwright;
using System.Threading.Tasks;

namespace SwagLabsDemo.Pages
{
    public class ItemPage
    {
        private readonly IPage _page;
        private ILocator AddToCartButton => _page.Locator("#add-to-cart");

        public ItemPage(IPage page)
        {
            _page = page;
        }

    
        public async Task AddToCart()
        {
            await AddToCartButton.ClickAsync();
        }   
    }
}
