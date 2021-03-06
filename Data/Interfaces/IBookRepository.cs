using System;
using System.Collections.Generic;
using LibraryManagement.Data.Model;

namespace LibraryManagement.Data.Interfaces
{
    public interface IBookRepository : IRepository<Book>
    {
        IEnumerable<Book> GetAllWithAuthor();

        IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate );

        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate); 
    }
}