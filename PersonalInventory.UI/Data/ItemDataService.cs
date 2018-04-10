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
    public class ItemDataService : IItemDataService
    {
        private Func<PersonalInventoryDbContext> _contextCreator;

        public ItemDataService(Func<PersonalInventoryDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }
        public async Task<List<Item>> GetAllAsync()
        {
           
            using (var ctx = _contextCreator())
            {
               var item =  await ctx.Items.AsNoTracking().ToListAsync();
               await  Task.Delay(5000);
                return item;
            }
        }
    }
}
