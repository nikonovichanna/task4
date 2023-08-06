int num = new Random().Next(1,20);
Console.WriteLine(num);
int start = 1;
while (start <= num) 
{
      if (start % 2 == 0)
      {
        Console.WriteLine(start);
      }
start++;      
}
   
