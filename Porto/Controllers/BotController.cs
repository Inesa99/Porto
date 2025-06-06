using Markdig;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Porto.Data.Models;
using System.Net.Http;
using System.Text;

namespace Porto.Controllers
{
    public class BotController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(string userMessage, BotTheme theme)
        {
            var response = await GetOllamaResponse(userMessage, theme);
            ViewBag.Response = response;
            ViewBag.UserMessage = userMessage;
            ViewBag.Theme = theme;
            return View();
        }

        [HttpPost]
        public async Task StreamResponse(string userMessage, BotTheme theme)
        {
            Response.ContentType = "text/event-stream";

            var client = new HttpClient();
            var themeDescription = GetThemeDescription(theme);

            var prompt = $"""
                You are a helpful AI assistant providing career guidance to people living in Porto, Portugal.
                Focus your answers within this topic: "{themeDescription}".
                Always give advice that is practical, supportive, and specific to opportunities and services available in Porto.

                Question: {userMessage}
            """;

            var requestBody = new
            {
                model = "gemma:2b",
                prompt = prompt,
                stream = true
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var request = new HttpRequestMessage(HttpMethod.Post, "http://localhost:11434/api/generate")
            {
                Content = content
            };

            using var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            using var stream = await response.Content.ReadAsStreamAsync();
            using var reader = new StreamReader(stream);

            while (!reader.EndOfStream)
            {
                var line = await reader.ReadLineAsync();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    try
                    {
                        dynamic chunk = JsonConvert.DeserializeObject(line);
                        string token = chunk?.response;
                        if (!string.IsNullOrEmpty(token))
                        {
                            var html = Markdown.ToHtml(token);
                            await Response.WriteAsync(html);
                            await Response.Body.FlushAsync();
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private string GetThemeDescription(BotTheme theme)
        {
            return theme switch
            {
                BotTheme.Living => "How to find and apply for jobs in Porto",
                BotTheme.Work => "Writing a simple CV and job application",
                BotTheme.Integration => "What to expect in interviews, workplace rights, and training in Porto",
                BotTheme.General => "General career guidance and support in Porto",
                _ => "General career guidance in Porto"
            };
        }

        private async Task<string> GetOllamaResponse(string userMessage, BotTheme theme)
        {
            using var client = new HttpClient();

            var themeDescription = GetThemeDescription(theme);

            var prompt = $"""
                You are a helpful AI assistant providing career guidance to people living in Porto, Portugal.
                Focus your answers within this topic: "{themeDescription}".
                Always give advice that is practical, supportive, and specific to opportunities and services available in Porto.

                Question: {userMessage}
            """;

            var requestBody = new
            {
                model = "gemma:2b",
                prompt = prompt,
                stream = false
            };

            var json = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:11434/api/generate", content);
            var result = await response.Content.ReadAsStringAsync();

            dynamic data = JsonConvert.DeserializeObject(result);
            string rawResponse = data.response;

            return Markdown.ToHtml(rawResponse);
        }
    }
}
