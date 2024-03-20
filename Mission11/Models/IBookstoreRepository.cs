namespace Mission11.Models
{
    //This is the interface
    public interface IBookstoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
