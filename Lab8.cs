using System;


namespace Lab8{
	

	public abstract class Figure{
		// public char hor_pos;
		// public int vert_pos;
		public int hor_pos;
		public int vert_pos;

		public int D(){
			vert_pos +=1;
			hor_pos +=0;
			Funcs.ChessBoard(vert_pos, hor_pos);
			return 0;
		}
		public int L(){
			hor_pos -=1;
			vert_pos +=0;
			Funcs.ChessBoard(vert_pos, hor_pos);
			return 0;
		}
		public int U(){
			vert_pos -=1;
			hor_pos +=0;
			Funcs.ChessBoard(vert_pos, hor_pos);
			return 0;
		}
		public int R(){
			hor_pos +=1;
			vert_pos +=0;
			Funcs.ChessBoard(vert_pos, hor_pos);
			return 0;
		}



		

		public abstract double Mov(); 

		



	}
	public  class Funcs{

		public static void ChessBoard(int m, int n){

			int[,] chess_board =new int[8,8];
			// chess_board[7,3] = 1;

			// for (int i = 0; i < chess_board.GetLength(0); i++)
			// {
			// 	System.Console.WriteLine();
			// 	for (int k = 0; k < chess_board.GetLength(1); k++)
			// 	{
			// 		System.Console.Write(chess_board[i,k]);
			// 	}
			// }
			try
			{
				int a =  chess_board[m,n];
				System.Console.WriteLine($"\nПозиция существует! m = {m}, n = {n}");
			}
			catch (System.Exception)
			{
				System.Console.WriteLine("Доска закончилась!");
				
			}
			
			

		}



	}



	public class Bishop : Figure{

		
		

		public override double Mov(){
			int h = 6;
			while(h > 0){
				U();R();
				h--;
			}
			System.Console.WriteLine("------------------------------------------");
			h = 6;
			while(h > 0){
			
				U();L();
				h--;
			}
			System.Console.WriteLine("------------------------------------------");
			h = 6;
			while(h > 0){
		
				D();R();
				h--;
			
			}
			System.Console.WriteLine("------------------------------------------");
			h = 6;
			while(h > 0){
			
				D();L();
				h--;
			}
			
			
			return 0;
		}

		
	}
	public class Pawn : Figure{




		public override double Mov(){

			return 0;
		}

	}








}