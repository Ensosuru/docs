using System.Text.RegularExpressions;
using Microsoft.Playwright.Xunit.v3;
using Xunit;

namespace docs;

public class ExampleTest : PageTest
{
    [Fact]
    public async Task HasTitle()
    {
        await Page.GotoAsync("https://playwright.dev");

        await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));
    }
}