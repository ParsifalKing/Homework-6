Rectangle rectangle = new Rectangle();

rectangle.Width = 5;
rectangle.Height = 5;

System.Console.Write("width = ");
rectangle.Width = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("height = ");
rectangle.Height = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Area = " + rectangle.GetArea(rectangle.Width, rectangle.Height));
