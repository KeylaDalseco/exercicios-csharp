class Movie
{
  public string Title { get; set; }
  public string Category { 
      get {return _category;}
      set {
              if(value != "Fantasia" && value != "ficção científica")
                throw new Exception("Categoria inválida");
              _category = value;
    }
    }

  string _category = "";

  public Movie(string title, string category)
  {
    Title = title;
    Category = category;
  }
}