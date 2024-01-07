int A = 323;
if (A % 7 == 0)
   {
       int B = A / 7;
           if (B % 23 == 0)
           {
               Console.WriteLine("Число кратно 7 и 23 одновременно");
           }
               else
           {
               Console.WriteLine("Число не кратно 7 и 23 одновременно");
           }
   }
   else
   {
       Console.WriteLine("Число не кратно 7 и 23 одновременно");
   }