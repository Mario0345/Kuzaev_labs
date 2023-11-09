using System;


namespace Lab5{

	// class Lab5_variant3{

		class Rectangle{

				
				

				private double height;
				public double Height
				{
					get { return height; }
					set 
					{
							// if(value <= 0 || width == value){
							// 	Console.WriteLine("Error! Enter positive value! And height != width.");
							// }
							// else{
							// 	height = value;
							// }
							height = value;
						 
					}
				}

				private double width;
				public double Width
				{
					get { return width; }
					set 
					{ 
						// if (value == height || width <=0)
						// {
						// 	Console.WriteLine("Error! Enter positive value! And height != width.");
						// }
						// else{
						// 	width = value;
						// }
						width = value;
						
					}
				}
				// public Rectangle(double ){

				// }

				public void Print(){
					Console.WriteLine($"Name of the figure is Rectangle! Height = {Height} and Width = {Width}");
				}
				
				public static double Rec_square(double Height ,double Width){
					if(Height <= 0 || Width <= 0){
						Console.WriteLine("Error! All sides must be larger than 0!");
						
					}
					return Height * Width;
				}
				
		
		}

		class Triangle{

			private double a_side;
			public double A_side
			{
				get { return a_side; }
				set
				 	{ 
						if(value <=0) Console.WriteLine("a_side must be >0!");
						a_side = value;
					}
			}

			private double b_side;
			public double B_side
			{
				get { return b_side; }
				set 
				{
					if(value <=0) Console.WriteLine("b_side must be >0!");
					b_side = value;
					 
				}
			}

			private double c_side;
			public double C_side
			{
				get { return c_side; }
				set 
					{ 
						if(value <=0) Console.WriteLine("c_side must be >0!");
						c_side = value;
					 
					}
			}

			public void Print(){
					Console.WriteLine($"This figure is Triangle! a_side = {A_side} , b_side = {B_side} , c_side = {C_side}");
				}


			public static double Triangle_square(double a, double b, double c){
				if(a + b <= c || a + c <= b || b + c <= a){
					Console.WriteLine("Sum of two sides must be larger than third side!");
					return 0;
				}
                            
				double p = (a + b + c) / 2;
				double square_Heron = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

				return square_Heron;

			}







		}









	// }



}