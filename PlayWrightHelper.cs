using Microsoft.Playwright;
using System.Threading.Tasks;

namespace YourNamespace.Tests.Helpers
{
    public static class PlaywrightHelper
    {
        public static async Task<(IBrowser Browser, IPage Page)> CreateBrowserAndPageAsync(bool headless = false)
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            
            {
                Headless = headless
            });
            var page = await browser.NewPageAsync();

            return (browser, page);
        }
    }
}
