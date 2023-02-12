using Catalog.Entities;

namespace Catalog.ItemRepositories{

    public class ItemRepository : IItemRepository
    {

        private readonly List<item> items = new()
        {
            new item{
                Id = Guid.NewGuid(),
                Name = "Milk",
                Price = 10,
                Balance = 100
            },
            new item{
                Id = Guid.NewGuid(),
                Name = "Pepper22",
                Price = 20,
                Balance = 10
            },
            new item{
                Id = Guid.NewGuid(),
                Name = "Beer5656",
                Price = 5,
                Balance = 1000
            },
        };

        public IEnumerable<item> GetItems()
        {
            return items;
        }
        public item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}