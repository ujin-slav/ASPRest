namespace Catalog.Entities
{
    public record item
    {
        public Guid Id {get;init;}
        public string Name {get;init;}   
        public decimal Price {get;init;} 
        public decimal Balance {get;init;}  
    }
}
