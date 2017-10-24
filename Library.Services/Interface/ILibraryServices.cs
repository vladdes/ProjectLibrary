using System;
using System.Collections.Generic;
using System.Text;
using Library.Data.Models;

namespace Library.Services.Interface
{
    public interface ILibraryServices
    {
        //book services
        IList<BOOK> GetBooksByRange(int index, int count);

        IList<BOOK> GetBooksByAuthor(string author);

        IList<BOOK> GetBooksByTitle(string title);

        IList<BOOK> GetBooksByISBN(string isbn);

        BOOK GetBookByISBN(string isbn);

        bool AddBook(BOOK book);

        bool DeleteBook(BOOK book);

        bool EditBook(BOOK book);

        //author services
        IList<AUTHOR> GetAuthorsByName(string input);

        bool DeleteAuthor(AUTHOR author);

        bool AddAuthor(AUTHOR author);

        bool EditAuthor(AUTHOR author);
        
        

    }
}
