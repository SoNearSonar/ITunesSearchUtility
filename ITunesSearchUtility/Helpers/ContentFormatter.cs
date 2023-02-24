namespace ITunesSearchUtility.Helpers
{
    public static class ContentFormatter
    {
        public static string FormatDate(string date)
        {
            return DateTime.Parse(date).ToString();
        }

        public static string FormatRuntime(long milliseconds)
        {
            TimeSpan time = TimeSpan.FromMilliseconds(milliseconds);
            return $"{time.Hours}:{time.Minutes}:{time.Seconds}";
        }

        public static long FormatUri(string uri)
        {
            if (uri.Contains("podcasts.apple.com") || uri.Contains("books.apple.com") || uri.Contains("/tv-season/"))
            {
                if (uri.Contains("id") && !uri.Contains("?i="))
                {
                    return CalculateStringRange(uri, "/id");
                }
                else
                {
                    return CalculateStringRange(uri, "/id", "?i=");
                }
            }
            return default;
        }

        public static long FormatArtistUri(string uri)
        {
            if (uri.LastIndexOf('/') != -1)
            {
                return long.TryParse(uri.AsSpan(uri.LastIndexOf('/') + 1), out long id) ? id : default;
            }
            else
            {
                return default;
            }
        }

        public static bool IsValidUri(string link)
        {
            return Uri.TryCreate(link, UriKind.Absolute, out Uri? uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps);
        }

        private static long CalculateStringRange(string source, string start)
        {
            string id = source[(source.LastIndexOf(start) + 3)..];
            return long.Parse(id);
        }

        private static long CalculateStringRange(string source, string start, string end)
        {
            string id = source.Substring(source.LastIndexOf(start) + 3, (source.LastIndexOf(end) - 3 - source.LastIndexOf(start)));
            return long.Parse(id);
        }
    }
}
