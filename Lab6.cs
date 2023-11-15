using System;

namespace Lab6
{

	

	public abstract class Figure1
	{
		
		private  string name;
		protected double parameter;
		
		public double Parameter
		{
			get { return parameter; }

			set
			{
				if (value <= 0)
				{
					System.Console.WriteLine("Value must be > 0!");
					
				}
				else{
					parameter = value;
				}
			}

		}

		public string Name
		{
			get { return name; }

			set{name = value;}
			

		}
		public Figure1(string name, double parameter)
		{
			Parameter = parameter;
			Name = name;


		}
		public abstract double Square_of_figure();
		// public override double Square_of_figure(){

		// 	double square = Math.Pow(Parameter, 2);
		// 	return square;
		// }

	}




		public abstract class Figure2 : Figure1{

			
			
			protected double parameter2;
			public double Parameter2{
				get {return parameter2;}
				set{
					if (value <= 0)
				{
					System.Console.WriteLine("Value must be > 0!");
				}
				else{
					parameter2 = value;
				}
				}
			}

			public Figure2(string name,double parameter, double parameter2)
			 : base( name,parameter){

				Parameter2 = parameter2;
			}


		 }


		public abstract class Figure3 : Figure2{

			protected double parameter3;
			public double Parameter3 { 
			get{return parameter3;}
			 set{
				if(value <= 0){
					System.Console.WriteLine("Parameter must be > 0!");
				}
				else{
					parameter3 = value;
				}
			 }
			  }
			public Figure3(string name,double parameter, double parameter2, double parameter3) 
			: base(name, parameter,parameter2){
				Parameter3 = parameter3;
			}



	}



	public class Rectangle_ : Figure2{
		private string name ;
		public string Name
		{
			get { return name; }
			set	{name = value;}
				
		}

			public override double Square_of_figure(){

			double square = parameter * parameter2;
			return square;
		}
		
		
		public Rectangle_(string name, double parameter, double parameter2)
		 : base(name,parameter,parameter2)
		{
			Name = name;
			double square2 = Square_of_figure();
			System.Console.WriteLine($"Название фигуры {name}");
			System.Console.WriteLine($"Первый параметр {name}а {parameter}");
			System.Console.WriteLine($"Второй параметр {name}а {parameter2}");
			System.Console.WriteLine($"Площадь {name}а {square2}\n");
		}


	}



	public class Triangle_ : Figure3{

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
			
		}
		
		
		


			public override double Square_of_figure()
		{
			double a = parameter;
			double b = parameter2;
			double c = parameter3;
			
			if(a + b <= c || a + c <= b || b + c <= a){
					Console.WriteLine("Ошибка!Сумма двух сторон оказалась меньше либо равна третьей стороне!");
					return 0;
				}
                            
				double p = (a + b + c) / 2;
				double square_Heron = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

				return square_Heron;
		}

		public Triangle_(string name, double parameter, double parameter2, double parameter3)
		 : base(name,parameter,parameter2, parameter3)
		{
			Name = name;
			double square3 = Square_of_figure();
			System.Console.WriteLine($"Название фигуры {Name}");
			System.Console.WriteLine($"Первый параметр {name}а: {parameter}");
			System.Console.WriteLine($"Второй параметр {name}а: {parameter2}");
			System.Console.WriteLine($"Третий параметр {name}а: {parameter3}");
			System.Console.WriteLine($"Площадь {name}а {square3}\n");
		}





	}








}