namespace GraphQLExample;

public class Query
{
    public string Hello(string name) => $"Hello {name}!";

    public IEnumerable<Book> GetBooks() => new[]
    {
        new Book("The Fellowship of the Ring", new Author("J.R.R. Tolkien", "Bio")),
        new Book("The Two Towers", new Author("J.R.R. Tolkien", "Bio")),
        new Book("The Return of the King", new Author("J.R.R. Tolkien", "Bio")),
    };
}

public record Author(string Name, string Bio);
public record Book(string Title, Author Author);