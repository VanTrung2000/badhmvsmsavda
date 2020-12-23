using Books.DAL.Interface;
using Books.Domain.Response;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Books.DAL
{
    public class BooksAPIRepository : BaseRepository, IBooksRepository
    {
        public async Task<IEnumerable<GetBooks>> Gets()
        {
            return await SqlMapper.QueryAsync<GetBooks>(cnn: connect,
                                                sql: "sp_GetBooks",
                                                commandType: CommandType.StoredProcedure);
        }
    }
}
