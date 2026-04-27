using FinalProject_ABBOTT.Models;

namespace FinalProject_ABBOTT.Areas.Admin.Models
{
    //A class used to create persistent cookies for the filtering.
    public class FilterCookies
    {
        private const string FiltersKey = "myfilters";
        private const string Delimiter = "|";

        private IRequestCookieCollection requestCookies { get; set; } = null!;
        private IResponseCookies responseCookies { get; set; } = null!;

        public FilterCookies(IRequestCookieCollection cookies) 
        {
            requestCookies = cookies;
        }

        public FilterCookies(IResponseCookies cookies) 
        {
            responseCookies = cookies;
        }

        //Saves the filters.
        public void SetMyFilter(List<string> filters)
        {
            string idString = string.Join(Delimiter, filters);

            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };

            responseCookies.Append(FiltersKey,idString, options);
        }

        //Grabs the saved filters
        public string[] GetFiltersIDs()
        {
            string cookie = requestCookies[FiltersKey]
        }
    }
}
