using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Framework.SharedLibary.Paging
{
    public static class IQueryablePaginateExtensions
    {       

        public static IPaginate<T> ToPaginate<T>(this IQueryable<T> source, int index, int size,
                                                 int from = 1)
        {
            if (from > index) throw new ArgumentException($"From: {from} > Index: {index}, must from <= Index");

            int count = source.Count();
            List<T> items = source.Skip((index - from) * size).Take(size).ToList();
            Paginate<T> list = new()
            {
                Index = index,
                Size = size,
                From = from,
                Count = count,
                Items = items,
                Pages = (int)Math.Ceiling(count / (double)size)
            };
            return list;
        }
    }
}
