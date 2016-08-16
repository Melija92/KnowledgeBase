using KnowledgeBase.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Web.Mvc;
using System.Web.UI;

namespace KnowledgeBase.Controllers
{
    public class BooksController : Controller
    {
        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult Index(string searchTerm, int pageNumber = 1)
        {
            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                TempData["SearchTerm"] = searchTerm;
                if (pageNumber == 1)
                {
                    BooksData booksData = null;
                    Books books = new Books();
                    var client = new RestClient("http://it-ebooks-api.info/v1/");
                    var request = new RestRequest();
                    request.Resource = "/search/" + searchTerm;
                    var response = client.Execute(request) as RestResponse;
                    if (response != null && ((response.StatusCode == HttpStatusCode.OK) && (response.ResponseStatus == ResponseStatus.Completed)))
                    {
                        booksData = JsonConvert.DeserializeObject<BooksData>(response.Content);
                        books.BookData = booksData;
                        TempData["Books"] = booksData;
                        return View(books);
                    }
                }
                else
                {
                    TempData["SearchTerm"] = searchTerm;
                    BooksData booksData = null;
                    Books books = new Books();
                    var client = new RestClient("http://it-ebooks-api.info/v1/");
                    var request = new RestRequest();
                    request.Resource = "/search/" + searchTerm + "/page/" + pageNumber.ToString();
                    var response = client.Execute(request) as RestResponse;
                    if (response != null && ((response.StatusCode == HttpStatusCode.OK) && (response.ResponseStatus == ResponseStatus.Completed)))
                    {
                        booksData = JsonConvert.DeserializeObject<BooksData>(response.Content);
                        books.BookData = booksData;
                        TempData["Books"] = booksData;
                        return View(books);
                    }
                }
            }
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult BooksDetail(string Id)
        {
            if (!string.IsNullOrWhiteSpace(Id))
            {
                BooksList books = new BooksList();
                var client = new RestClient("http://it-ebooks-api.info/v1/");
                var request = new RestRequest();
                request.Resource = "/book/" + Id;
                var response = client.Execute(request) as RestResponse;
                if (response != null && ((response.StatusCode == HttpStatusCode.OK) && (response.ResponseStatus == ResponseStatus.Completed)))
                {
                    books = JsonConvert.DeserializeObject<BooksList>(response.Content);
                    return View(books);
                }
            }
            return View();
        }
    }
}