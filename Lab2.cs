using System;
using System.Collections.Generic;


namespace Lab2{
	public class Lab2_variant3{

		public static void First_task(){
			Console.Write("Введите время в минутах:");
			double a = double.Parse(Console.ReadLine());
			Console.Write("1-секунды, 2-часы, 3-сутки:");
			int b = int.Parse(Console.ReadLine());

			double res;
			switch(b){
				case 1:
					res = a * 60;
					Console.WriteLine($"В {a}-минутах {res}-секунд.");
					break;
				case 2: 
					res = Math.Round(a / 60,3);
					Console.WriteLine($"В {a}-минутах {res}-часов.");
					break;
				case 3:
					res = Math.Round(a / (24*60),3);

					Console.WriteLine($"В {a}-минутах {res}-суток.");
					break;
			}


		}


		public static void Second_task(){

			List<int> nums = new List<int>();
			int first,second,third,last;
			for (int i = 1000; i < 10000; i++)
			{
				first = i / 1000;
				second = (i / 100) % 10;
				third = (i / 10) % 10;
				last = i % 10;
				if((first + last) == (second + third)){
					nums.Add(i);
				}
			}

			string str_list = String.Join(",",nums);
			Console.WriteLine(str_list);

		}

		public static void Third_task(double eps){
			
			double sum_while = 0;
			int n = 1;
			double elem = (2*n-1)/Math.Pow(2,n);
			while (sum_while <= eps)
			{
				sum_while += elem; 
				n++;
			}
			Console.WriteLine("sum_while = " + sum_while);
		





		}





	}



}