﻿using Dev_Community.Models;
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

        public async Task<Board> Add(Board item)
        {
            try
            {
                context.Add(item);
                context.SaveChanges();
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }
          
        }

        public async Task<Board> Get(int ID)
        {
            return context.Boards.Find(ID);
        }

        public async Task<List<Board>> GetAll()
        {
            return context.Boards.ToList();
        }

        public Task<Board> Remove(Board item)
        {
            throw new NotImplementedException();
        }

        public async Task<Board> Update(Board item)
        {
            context.Update(item);
            context.SaveChanges();
            return item;
        }
    }
}
