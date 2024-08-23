using System.Net;

namespace MagicVilla_Web.Models
{
    public class APIResponse
    {
        // Has to do with the api response
        public HttpStatusCode StatusCode { get; set; }

        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }

        public object Result { get; set; }
    }
}
