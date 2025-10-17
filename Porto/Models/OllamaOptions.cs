namespace Porto.Models
{
    public class OllamaOptions
    {
        public OllamaOptions(string model, string url)
        {
            Model = model;
            Url = url;
        }
        public string Model { get; set; }
        public string Url { get; set; }
    }
}
