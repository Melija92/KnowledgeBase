using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnowledgeBase.Models
{
    public class Books
    {
        public string SearchTerm { get; set; }

        public BooksData BookData { get; set; }
    }

    public class BooksData
    {
        public string Error { get; set; }

        public string Time { get; set; }

        public string Total { get; set; }

        public string Page { get; set; }

        public List<BooksSearch> Books { get; set; }
    }

    public class BooksSearch
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }

    public class BooksList
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string SubTitle { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public string Page { get; set; }

        public string Year { get; set; }

        public string Publisher { get; set; }

        public string Image { get; set; }

        public string Download { get; set; }
    }
}