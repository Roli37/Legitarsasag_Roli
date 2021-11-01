using Legitarsasag_Roli.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Services
{
    public class LegitarsasagRepository : ILegitarsasagRepository
    {
        private readonly LegitarsasagContext _legitarsasagContext;
        public LegitarsasagRepository(LegitarsasagContext context)
        {
            _legitarsasagContext = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
