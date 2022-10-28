Console.WriteLine("enter numbers separeted by spase ");
int [] userarray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int count = 0;
int positive(int[] userarray)
{
  for (int i = 0; i < userarray.Length; i++)
  {
      if (userarray[i] >= 0)
      {
          count++;
      }
  }
  return count;
}

Console.WriteLine();
Console.WriteLine($"numbers > 0: " + (positive(userarray)));