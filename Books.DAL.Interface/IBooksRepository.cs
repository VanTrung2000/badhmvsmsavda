using Books.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL.Interface
{
    public interface IBooksRepository
    {
        Task<IEnumerable<GetBooks>> Gets();
    }
}
