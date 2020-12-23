using Books.BAL.Interface;
using Books.DAL.Interface;
using Books.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Books.BAL
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository bookRepository;
        public BooksService(IBooksRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public async Task<IEnumerable<GetBooks>> Gets()
        {
            return await bookRepository.Gets();
        }
    }
}
