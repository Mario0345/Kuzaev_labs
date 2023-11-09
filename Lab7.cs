using System;
using System.Linq;
using System.Collections.Generic;



namespace Lab7{
	public class Lab7_var3{

		public static void Task_3(){

			string[] arr = {"Class ended in five minutes and all I could think was, an hour is too long for lunch.","Since the start of the semester, I had been looking forward to the part of Mr. Gladly’s World Issues class where we’d start discussing capes.",  "Now that it had finally arrived, I couldn’t focus.",  "I fidgeted, my pen moving from hand to hand, tapping, or absently drawing some figure in the corner of the page to join the other doodles.",  "My eyes were restless too, darting from the clock above the door to Mr. Gladly and back to the clock.",  "I wasn’t picking up enough of his lesson to follow along.",  "Twenty minutes to twelve; five minutes left before class ended.", "He was animated, clearly excited about what he was talking about, and for once, the class was listening.",  "He was the sort of teacher who tried to be friends with his students, the sort who went by “Mr. G” instead of Mr. Gladly.",  "He liked to end class a little earlier than usual and chat with the popular kids, gave lots of group work so others could hang out with their friends in class, and had ‘fun’ assignments like mock trials."};
			string text = "Class ended in five minutes and all I could think was, an hour is too long for lunch.Since the start of the semester, I had been looking forward to the part of Mr. Gladly’s World Issues class where we’d start discussing capes.  Now that it had finally arrived, I couldn’t focus.  I fidgeted, my pen moving from hand to hand, tapping, or absently drawing some figure in the corner of the page to join the other doodles.  My eyes were restless too, darting from the clock above the door to Mr. Gladly and back to the clock.  I wasn’t picking up enough of his lesson to follow along.  Twenty minutes to twelve; five minutes left before class ended.He was animated, clearly excited about what he was talking about, and for once, the class was listening.  He was the sort of teacher who tried to be friends with his students, the sort who went by “Mr. G” instead of Mr. Gladly.  He liked to end class a little earlier than usual and chat with the popular kids, gave lots of group work so others could hang out with their friends in class, and had ‘fun’ assignments like mock trials.";
			string[] arr_text = text.Split(' ');
			string[] arr_test = {"boba", "biba", "soba"}; //можно проверить работу дупликатных максимумов
			int counter = 0;
			List<int> lengths = new List<int>();
		
			int length_count = 0;
			string str ;
			string[] arr2 = {};
			for (int k = 0; k < arr.Length; k++)
			{
				arr2 = arr[k].Split(' ');
				lengths.Add(arr2.Length);
				
			}
			string bb = string.Join(", ",lengths);
			Console.WriteLine(bb);
			int count_of_maximums = 0;
			int max = lengths.Max();
			foreach (var item in lengths)
			{
				if(item == max){
					count_of_maximums+=1;
				}
			}
			System.Console.WriteLine($"Max element = {max} \n Number of maximums = {count_of_maximums}");
		}
		

	}









}