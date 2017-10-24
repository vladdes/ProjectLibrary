using System;
using System.Collections.Generic;
using System.Text;
using Library.Data.Models;
using Library.Services.Interface;

namespace Library.Services
{
    class LibraryServices :ILibraryServices
    {
        public IList<BOOK> GetBooksByRange(int index, int count)
        {
            throw new NotImplementedException();
        }

        public IList<BOOK> GetBooksByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public IList<BOOK> GetBooksByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public IList<BOOK> GetBooksByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public BOOK GetBookByISBN(string isbn)
        {
            throw new NotImplementedException();
        }

        public bool AddBook(BOOK book)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBook(BOOK book)
        {
            throw new NotImplementedException();
        }

        public bool EditBook(BOOK book)
        {
            throw new NotImplementedException();
        }

        public IList<AUTHOR> GetAuthorsByName(string input)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAuthor(AUTHOR author)
        {
            throw new NotImplementedException();
        }

        public bool AddAuthor(AUTHOR author)
        {
            throw new NotImplementedException();
        }

        public bool EditAuthor(AUTHOR author)
        {
            throw new NotImplementedException();
        }
    }
}
