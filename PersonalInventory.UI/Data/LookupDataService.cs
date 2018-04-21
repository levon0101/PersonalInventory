using PersonalInventory.DataAccess;
using PersonalInventory.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.UI.Data
{
    public class LookupDataService : IItemLookupDataService
    {
        private Func<PersonalInventoryDbContext> _contextCreator;

        public LookupDataService(Func<PersonalInventoryDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<IEnumerable<LookupItem>> GetItemLookupAsync()
        {
            using(var ctx = _contextCreator())
            {
                return await ctx.Items.AsNoTracking()
                    .Select(f => new LookupItem
                    {
                        Id = f.Id,
                        DisplayMember = f.ItemName
                    }).ToListAsync();
            }
        }
    }
}
