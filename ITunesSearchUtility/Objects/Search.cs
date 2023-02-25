﻿namespace ITunesSearchUtility.Objects
{
    public class Search
    {
        public string Id;

        public bool IsFavorite;

        public string SearchContent;

        public SearchType SearchType;

        public int SearchCount;

        public string SearchCountryCode;

        public Search(string id, bool isFavorite, string searchContent, SearchType searchType, int searchCount, string searchCountryCode)
        {
            Id = id;
            IsFavorite = isFavorite;
            SearchContent = searchContent;
            SearchType = searchType;
            SearchCount = searchCount;
            SearchCountryCode = searchCountryCode;
        }

        public string GetFavoriteIcon()
        {
            return IsFavorite ? "\u2605" : "";
        }
    }
}
