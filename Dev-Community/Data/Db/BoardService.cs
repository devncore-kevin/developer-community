using Dev_Community.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev_Community.Data
{
    public interface IBoardService : IDBService<Board>
    {

    }
    public class BoardService : DBServiceClass, IBoardService
    {
        public BoardService(developtiveContext _context) : base(_context) { }

        public Task<Board> Add(Board item)
        {
            throw new NotImplementedException();
        }

        public Task<Board> Get(string ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Board>> GetAll()
        {
            return context.Boards.ToList();
        }

        public Task<Board> Remove(Board item)
        {
            throw new NotImplementedException();
        }

        public Task<Board> Update(Board item)
        {
            throw new NotImplementedException();
        }
    }
}
