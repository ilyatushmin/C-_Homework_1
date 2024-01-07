int x = -10;
int y = 8;
if (x > 0)
{
   if (y > 0)
   {
       Console.WriteLine("Первый квадрант");
   }
   else
   {
      Console.WriteLine("Четвертый квадрант");
   }
}
else
{
   if (y > 0)
   {
       Console.WriteLine("Второй квадрант");
   }
   else
   {
       Console.WriteLine("Третий квадрант");
   }
}