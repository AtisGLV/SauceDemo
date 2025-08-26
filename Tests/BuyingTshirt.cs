using Microsoft.Playwright; 
using SwagLabsDemo.Pages;

namespace SwagLabsDemo
{
    public class SimpleTest
    {
        [Fact]
        public async Task Shirtbuy()
        {
            using var playwright = await Playwright.CreateAsync();
            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            var page = await browser.NewPageAsync();
            var loginPage = new LoginPage(page);
            var homePage = new HomePage(page);
            var itemPage = new ItemPage(page);
            var cartPage = new CartPage(page);
            var checkoutPage = new CheckoutPage(page);
            var checkoutOverviewPage = new CheckoutOverviewPage(page);
            var checkoutCompletePage = new CheckoutCompletePage(page);

            //Navigate to website and log in
            await loginPage.GoToWebsite();
            await loginPage.LogInAsStandardUser();

            //Choose right item and go to checkout 
            await homePage.GoToItemTshirt();
            await itemPage.AddToCart();
            await homePage.GoToShoppingCart();
            await cartPage.GoToCheckoutAsync();

            //Fill form with default data
            await checkoutPage.FillCheckoutWithTestData(); 
            await checkoutPage.Continue();

            //Check if right item has been added
            await checkoutOverviewPage.IsItemInCartAsync("Sauce Labs Bolt T-Shirt");  
            await checkoutOverviewPage.FinishCheckout();

            //Check final confirmation
            await checkoutCompletePage.IsCheckoutComplete(); 
        }
    }
}
