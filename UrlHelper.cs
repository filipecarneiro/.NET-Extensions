namespace Extensions
{
    public static class UrlHelper
    {
        public static string GetHost(string url)
        {
            Uri uri = new Uri(url);
            return uri.Host;
        }
    }
}
