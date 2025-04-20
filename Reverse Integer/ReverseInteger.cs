 public static int Reverse(int x)
 {
     int y = 0;

     while (x != 0)
     {

         if (y > int.MaxValue / 10 || (y == int.MaxValue / 10 && x % 10 > 7))
             return 0;
         if (y < int.MinValue / 10 || (y == int.MinValue / 10 && x % 10 < -8))
             return 0;

         y = y * 10 + x % 10;
         x = x / 10;

     }
     x = y;
     return x;
 }
