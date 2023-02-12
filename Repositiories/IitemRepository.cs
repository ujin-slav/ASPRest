namespace Catalog.Entities {
    public interface IItemRepository
    {
        item GetItem(Guid id);
        IEnumerable<item> GetItems();
    }
}