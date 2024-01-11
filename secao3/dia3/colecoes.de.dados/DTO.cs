namespace Custommer
{
public class Customer {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? City { get; set;}
    public string? Password { get; set; }
}

List<Customer> customers = new List<Customer>
{
    new Customer { Id = 1, Name = "Rebeca", City = "Recife", Password =  "706632"},
    new Customer { Id = 2, Name = "José", City = "Manaus", Password =  "128620"},
    new Customer { Id = 3, Name = "Sandra", City = "Salvador", Password =  "043407"}
};
}

// com consulta linq e o retorno
var customersList = from customer in customers
                            select customer;

foreach(Customer customer in customersList)
{
    Console.WriteLine(customer.Name + " - City: " +customer.City + " - Password: " + customer.Password);
}

// Rebeca - City: Recife - Password: 706632
// José - City: Manaus - Password: 128620
// Sandra - City: Salvador - Password: 043407


// AGORA COM DTO

public class CustomerBasicData {
    public string? Name { get; set; }
    public string? City { get; set;}
    
}

var customersList = from customer in customers
                            select new CustomerBasicData { Name = customer.Name, City = customer.City };

foreach(CustomerBasicData customer in customersList)
{
    Console.WriteLine(customer.Name + " - City: " +customer.City);
}

// DTO ANINHADO

public class Author {
    public int Id { get; set; }
    public string? Name { get; set; }
}

public class Book {
    public string? Name { get; set; }
    public int AuthorId { get; set;}
}

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


public class BookDTO { // NOSSO DTO CRIADO
    public string? BookName { get; set; }
    public string? AuthorName { get; set; }
}

var booksList = from book in books
                from author in authors
                  where author.Id == book.AuthorId
                select new BookDTO { BookName = book.Name, AuthorName = author.Name };

foreach(BookDTO book in booksList)
{
    Console.WriteLine(book.BookName + " - Author: " +book.AuthorName);
}