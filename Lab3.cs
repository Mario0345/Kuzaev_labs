using System;

namespace Lab3{

	class Lab3_variant3{
		
		

		public static int Task_1_LCM(int a, int b, int c){

			static int GCD(int a, int b){
			int remainder;
			while (b != 0)
			{
				remainder = a % b;
				a = b;
				b = remainder;
			}
			return a;
		}

			int result = a * b * c  / (GCD(a,b) * GCD(a,c) * GCD(b,c));
			return result;
		}

		public static int Task_2(int d, int m, int y){
			
			static int month(int m, int y ){
				if(y < 1600 && y > 2400){
					Console.WriteLine("Error! Year < 1600 or > 2400!"); 
					return 0;
				} 
				if(y % 4 == 0 && y != 1700 && y != 1800 && y != 2100 && y != 2200 && y != 2300 ){
					int[] arr_of_months =new int[12] {31,29,31,30,31,30,31,31,30,31,30,31};
					int sum = 0;
					for (int i = 0; i < m; i++)
					{
						sum += arr_of_months[i];
					}
					return sum;
				}
				else{
					int[] arr_of_months =new int[12] {31,28,31,30,31,30,31,31,30,31,30,31};
					int sum = 0;
					for (int i = 0; i < m; i++)
					{
						sum += arr_of_months[i];
					}
					return sum;
				}
				
			
			}

			int remaining_days = 365 - (month(m,y) + 1 + d);
			return remaining_days;
		}


		public static int Task_3(int num,int reverse = 0){
		
		if(num > 0){
			return Task_3(num/10, reverse* 10 + (num % 10));
		}
		
		return reverse;
	}




	}

	

}