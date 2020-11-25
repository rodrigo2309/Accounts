using AccountWebMVC.Data;
using AccountWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AccountWebMVC.Services
{
    public class ReleasesRecordService
    {
        private readonly AccountWebMVCContext _context;
        public ReleasesRecordService(AccountWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Release>> FindByDateAsync(DateTime? minDate,DateTime? maxDate)
        {
            var result = from obj in _context.Release select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            };
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x=> x.Local)
                .OrderByDescending(x=> x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Local,Release>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Release select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            };
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Local)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Local)
                .ToListAsync();
        }

    }
}
