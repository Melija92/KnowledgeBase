using KnowledgeBase.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeBase.Controllers
{
    public class BooksController : Controller
    {
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