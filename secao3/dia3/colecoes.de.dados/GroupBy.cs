
public class Developer2 {
    public string? Name { get; set; }
    public string? ProgrammingLanguage { get; set; }
}



List<Developer2> developers = new List<Developer2>
{
    new Developer2 { Name = "Julia", ProgrammingLanguage = "C#" },
    new Developer2 { Name = "Paulo", ProgrammingLanguage = "Java" },
    new Developer2 { Name = "Rebeca", ProgrammingLanguage = "C#" },
    new Developer2 { Name = "Rodrigo", ProgrammingLanguage = "C#" },
    new Developer2 { Name = "Joana", ProgrammingLanguage = "Java" },
    new Developer2 { Name = "Alan", ProgrammingLanguage = "Python" }
};


var developerSkills = from developer in developers
                      group developer by developer.ProgrammingLanguage into languages
                      select languages;
