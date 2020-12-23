using Books.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Books.BAL.Interface
{
    public interface IBooksService
    {
        Task<IEnumerable<GetBooks>> Gets();
    }
}
