// =========== COUNT
int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };


numbers.Count(); // Resultado: 7

var numQuery =
    from num in numbers
    where (num % 2) == 0
    select num;

numQuery.Count(); // Resultado: 4


// =========== SUM
class Student
{
    public string? Name { get; set; }
    public int[]? Scores;
}

Student[] students = {
    new Student { Name="José", Scores=new int[3] { 100, 90, 80 } },
    new Student { Name="Maria", Scores=new int[3] { 60, 90, 100 } },
};

var numQuery2 =
    from num in numbers
    where (num % 2) == 0
    select num;

numQuery2.Sum(); // Resultado: 12

//OU 

var studentsWithHighScore = 
    from student in students
    where student.Scores.Sum() > 250 // METODO UTILIZADO NO LINQ
    select student;


// ======== MIN

var studentsWithAScoreLessThan70 = 
    from student in students
    where student.Scores.Min() <= 70
    select student;

//ou

numQuery2.Min(); // Resultado: 12

// ========= MAX

numQuery2.Max(); // Resultado: 12

//ou

var studentsWithMaxScoreEqual100 = 
    from student in students
    where student.Scores.Max() == 100
    select student;


// ========== COUNT

// ========== AVERAGE
