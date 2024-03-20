namespace Mission11.Models.ViewModels
{
    // combine models
    public class BookListViewModels
    {
        public IQueryable<Book> Books { get; set; }
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
