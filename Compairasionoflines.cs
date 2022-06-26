
  public class line
 { 
	 int x1 = 4, x2 =8;
     int y1 = 12, y2 = 24;
     double Length;
	 int a1 = 3, a2 = 6;
	 int b1 = 9, b2 = 12;
	 double Length1;
       void cordinate()
	   {
         Length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
		 Console.WriteLine(Length);
		
	      Length1 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
           Console.WriteLine(Length1);

           if (Length== Length1)
           {
	         Console.WriteLine("both lines are equal");
           }
	       else if (Length > Length1)
            {
	          Console.WriteLine("Line one is greater than Line two");
             }	
	
            else
            {
	          Console.WriteLine("Both lines are not equals");
       	
             }
	
	   }
           public static void Main()
            {
            line l1 = new line();
	        l1.cordinate();
            }
  }