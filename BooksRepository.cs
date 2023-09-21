using System;
namespace obg_opgave
{
	public class BooksRepository
	{
		private int _nextId = 1;
		private List<Book> _books = new();
		public BooksRepository()
		{
			_books.Add(new Book() { Id = _nextId++, Price = 100, Title = "Narnia" });
            _books.Add(new Book() { Id = _nextId++, Price = 200, Title = "IBoy" });
            _books.Add(new Book() { Id = _nextId++, Price = 300, Title = "48 laws of power" });
            _books.Add(new Book() { Id = _nextId++, Price = 400, Title = "Art of Seduction" });
            _books.Add(new Book() { Id = _nextId++, Price = 500, Title = "Poor father & rich father" });
        }


		public IEnumerable<Book> Get(int? priceBelow = null, string? titlePart = null, string? orderBy = null)
		{
			IEnumerable<Book> result = new List<Book>(_books);

			if (priceBelow != null)
			{
				result = result.Where(m => m.Price < priceBelow);
			}

			if (titlePart != null)
			{
				result = result.Where(m => m.Title!=null && m.Title.Contains(titlePart));
			}
		}
    }
}

