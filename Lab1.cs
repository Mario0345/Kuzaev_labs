using System;


namespace Lab1{

	public class Lab1_kuzaev_variant3{
		

				static public double First_task(double a, double b, double c){
					double solution = 1/(2*a*b-3) - 3 *c *c;
					return solution;

				}
				
				static public double Second_task(int n){
					
					int[] array =new int[4];
					for(int i = 0;i < array.Length; i++){
						array[i] = n % 10;
						n /=10;
					}
					
					int second_number = array[2];
					int third_number = array[1];
					int sol =  second_number * second_number + third_number * third_number * third_number;
					return sol;
					
				}

				static public bool Third_task(int n){

					int[] arr =new int [4];
					int[] rev_arr = new int[4];
					for (int k = 0; k < arr.Length; k++)
					{
						arr[k] = n%10;
						n /=10;
					}
					Array.Reverse(arr);
					int sum_of_nums = arr[0] + arr[1] + arr[2] + arr[3];
					int product_of_nums = arr[0] * arr[1] * arr[2] * arr[3];
					bool answer = sum_of_nums == product_of_nums + 1 ? true: false;
					return answer;
				}

				static public void Fourth_task(int n){

					int[] arr =new int [4];
					int[] new_arr = new int[4];
					for (int k = 0; k < arr.Length; k++)
					{
							arr[k] = n%10;
							n /=10;
					}
					Array.Reverse(arr);
					for (int l = 0; l < arr.Length; l++)
					{
						if(arr[l] % 2 == 0){
							new_arr[l] = arr[l];
							System.Console.Write($"{arr[l]}, ");
						}
					}
					// string str_arr = string.Join(",",new_arr);
					// return str_arr;

				}
        
		}



}

