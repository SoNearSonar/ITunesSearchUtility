using Microsoft.VisualBasic.Logging;
using System.Security.Policy;

namespace ITunesSearchUtility.Helpers
{
    public static class ContentFormatter
    {
        public static string FormatDate(string date)
        {
            return DateTime.Parse(date).ToString();
        }

        public static long FormatUri(string uri)
        {
            string id;
            if (uri.Contains("podcasts.apple.com") || uri.Contains("books.apple.com"))
            {
                if (uri.Contains("id") && !uri.Contains("?i="))
                {
                     id = uri.Substring(uri.LastIndexOf("/id") + 3, uri.Length - (uri.LastIndexOf("/id") + 3));
                     return long.Parse(id);
                }
                else
                {
                    id = uri.Substring(uri.LastIndexOf("/id") + 3, uri.Length - (uri.LastIndexOf("?i=") + 6));
                    MessageBox.Show(id);
                    return long.Parse(id);
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
    }
}
