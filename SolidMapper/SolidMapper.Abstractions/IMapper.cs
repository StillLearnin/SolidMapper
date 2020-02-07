﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace SolidMapper
{
    public interface IMapper
    {
        Task<TDest> MapAsync<TSource, TDest>(TSource source, TDest dest);

        // Add a separate method for mapping multiple items, per Eric Lippert's comment on
        // https://stackoverflow.com/questions/8727523/generic-not-constraint-where-t-ienumerable
        Task<IList<TDest>> MapRangeAsync<TSource, TDest>(IEnumerable<TSource> source);
    }
}
