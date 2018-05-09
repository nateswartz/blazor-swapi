using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NateSwartz.Blazor.SwApi.Server.Controllers
{
    [Route("api/[controller]")]
    public class ImagesController : Controller
    {
        // Name must have dashes (-) instead of spaces
        [HttpGet("characters/{name}")]
        public async Task<string> GetCharacterImage(string name)
        {
            var client = new HttpClient();
            var imageSearchPage = await client.GetAsync($"https://www.starwars.com/databank/{name}");
            var textContent = await imageSearchPage.Content.ReadAsStringAsync();
            var match = Regex.Matches(textContent, "img src=\"(.*)\" class=\"thumb");
            if (match.Count > 0 && match[0].Success)
            {
                return match[0].Groups[1].Value;
            }
            return "";
        }
    }
}