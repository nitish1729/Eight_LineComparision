public class line
 { 
	  int x1 = 4, x2 = 2;
      int y1 = 4, y2 = 5;
     double Length;
	
    void cordinate()
	{
 Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
		Console.WriteLine(Length);
 }
	
   public static void Main()
   {
    line l1 = new line();
	  l1.cordinate();
   }
}