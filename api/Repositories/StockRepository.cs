using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<List<Stock>> GetAllAsync()
        {
            /* null check*/
            if (_context.Stocks == null)
            {
                throw new ArgumentNullException(nameof(_context));
            }

            return await _context.Stocks.ToListAsync();
        }
    }
}