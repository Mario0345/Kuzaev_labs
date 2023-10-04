using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;


namespace Lab4{


	class Lab4_variant3{
		public static void Task_1(){

			int[] arr = new int[] {2,4,5,3,2,2,1};
			int sum = 0;
			int prod;
			for (int i = 1; i < arr.Length; i++)
			{
				prod = arr[i-1] * arr[i];
				sum += prod;
			}
			Console.WriteLine("a1*a2 + a2*a3+... ="+sum);
			
		}

		public static string Task_2(int a){


			int[] arr = new int[] {2,4,5,3,2,9,1,9};
			int max = arr[0];
			int index = 0;
			for (int k = 0; k < arr.Length; k++)
			{
				if(arr[k] > max){
					max = arr[k];
					index = Array.IndexOf(arr,max);
				}
			}
			Array.Resize(ref arr, arr.Length + 1);
			arr.SetValue(a,index+1);
			string str =String.Join(',',arr);
			return str;
		}

		public static void Task_3(){

			int[] arr = new int[]{5,3,6,4,53,1,9};
			int min = arr[0];
			for (int g = 0; g < arr.Length; g++)
			{
				if(arr[g] < min){
					min = arr[g];
					 
				}
			}
			arr = arr.Where(val => val != min).ToArray();
			string str =string.Join(",",arr);
			Console.WriteLine(str);
		}

		public static void Task_4(){
			// не понимаю что от меня хотят, уточнить

			var priceName = new Dictionary<string,decimal>();
			priceName.Add("M&S",108);
			priceName.Add("мята",162);
			priceName.Add("Крокант",70);
			priceName.Add("Skittles",120);

			var min = priceName.Values.OfType<decimal>().Min();
			var myKey = priceName.FirstOrDefault(x => x.Value == min).Key;
			
			Console.WriteLine(myKey,min);


		




		}






	} 
	





}