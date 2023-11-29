public class DataUtil
{
    public static void Main(string[] args)
    {
        var date = new DateTime(2022, 10, 2, 8, 35, 0); // tempo desejado
        Console.WriteLine(date.ToString()); // transformamos em string para imprimir
    }
}

// DateTime.Now
  public class DataUtil2
  {
      public static void Main2(string[] args)
      {
          var dataType = DateTime.Now;
          Console.WriteLine(dataType.GetType()); // retorno:   System.DateTime
      }
  }

    public class DataUtil3
  {
      public string getTimeNow()
      {
          return "O momento de tempo atual é " +DateTime.Now;
      }
  }   


// DateTime.Date
  public class DataUtil4
  {
      public static void Main4(string[] args)
      {
          var date = new DateTime(2022, 10, 2, 8, 35, 0);
          var dateOnly = date.Date;
          Console.WriteLine(dateOnly.ToString());
      }
  }

// DateTime.Day

  public class DataUtil5
  {
      public static void Main5(string[] args)
      {
          var date = new DateTime(2022, 10, 2, 8, 35, 0);
          var dayOnly = date.Day;
          Console.WriteLine(dayOnly.ToString());
      }
  }

  // DateTime.Month

  public class DataUtil6
  {
      public static void Main6(string[] args)
      {
          var date = new DateTime(2022, 10, 2, 8, 35, 0);
          var monthOnly = date.Month;
          Console.WriteLine(monthOnly.ToString());
      }
  }

  // DateTime.Year

  public class DataUtil7
  {
      public static void Main7(string[] args)
      {
          var date = new DateTime(2022, 10, 2, 8, 35, 0);
          var yearOnly = date.Year;
          Console.WriteLine(yearOnly.ToString());
      }
  }

  // Para não repetir: De forma similar, temos as propriedades .Hour, .Minute, .Second, .Millisecond e .DayOfWeek, que retornam os componentes de Hora, Minuto, Segundo, Milissegundo e Dia da semana, respectivamente.

