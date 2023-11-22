// Para declarar e criar um Array multidimensional:
class PlayingWithArrays
{
  public static void muldiDimArrays()
  {
    int[,] multiDimensionalArray1 = new int[2, 3];
  }
}

// Para declarar e criar um Array multidimensional com as chaves {}:
class PlayingWithArrays1
{
  public static void muldiDimArrays1()
  {
    int[,] multiDimensionalArray = { { 1, 2, 3 }, { 4, 5, 6 } };
  }
}

// ou pode declarar com os dois:
int[,] array = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };