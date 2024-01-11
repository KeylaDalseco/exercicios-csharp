// ordenação de dados - por padrão e ascendente a-z
List<string> names = new List<string>
{
    "Roberta", "Laura", "Maria", "Ana", "Pedro", "Ricardo"
};

var orderedNames = from name in names
                    orderby name
                    select name;

foreach(string orderedName in orderedNames) {
    Console.WriteLine(orderedName);
}

// ordenação com DTOS

List<Author> authors = new List<Author>
{
    new Author { Id = 1, Name = "Clarice Lispector"},
    new Author { Id = 2, Name = "Jorge Amado" }
};

List <Book> books = new List<Book>
{
    new Book { Name = "Capitães da Areia", AuthorId = 2},
    new Book { Name = "Água Viva", AuthorId = 1},
    new Book { Name = "A hora da Estrela", AuthorId = 1},
    new Book { Name = "Cacau", AuthorId = 2},
};

var booksList = from book in books
                from author in authors
                where author.Id == book.AuthorId
                orderby author.Name
                select new BookDTO { BookName = book.Name, AuthorName = author.Name };

// OrderByDescending

List<string> names2 = new List<string>
{
    "Roberta", "Laura", "Maria", "Ana", "Pedro", "Ricardo"
};

var orderedNames2 = from name in names
                    orderby name descending
                    select name;

foreach(string orderedName in orderedNames) {
    Console.WriteLine(orderedName);
}