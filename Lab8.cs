using System;
using System.Net;


namespace Lab8{
	

	public abstract class Figure{
	


		private char hor_pos;
		public char Hor_pos { get; set; }
		private int  vert_pos;
		public int Vert_pos { get; set; }
		public void PrintInitial(){
			int num_hor_pos = Funcs.Stupid_CharToNumber(Hor_pos);
			int num_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			System.Console.Write("\nИзначальное состояние доски:");
			Funcs.ChessBoard(num_vert_pos, num_hor_pos);
		}
		public int D_pawn(){
			int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
			D_vert_pos = 3;
			while(res !=2){
				D_vert_pos +=1;
				D_hor_pos +=0;
				res = Funcs.ChessBoard(D_vert_pos, D_hor_pos);
			}
			return res;
		}
		public int U_pawn(){
			int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
			D_vert_pos = 4;
			while(res !=2){
				D_vert_pos -=1;
				D_hor_pos +=0;
				res = Funcs.ChessBoard(D_vert_pos, D_hor_pos);
			}
			return res;
		}
		public int U(){
			int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
			while(res !=2){
				D_vert_pos -=1;
				D_hor_pos +=0;
				res = Funcs.ChessBoard(D_vert_pos, D_hor_pos);
			}
			return res;
		}
		public int D(){
			int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
			while(res !=2){
				D_vert_pos +=1;
				D_hor_pos +=0;
				res = Funcs.ChessBoard(D_vert_pos, D_hor_pos);
			}
			return res;
		}
		public int UU(){
			int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
		
			D_vert_pos -=2;
			D_hor_pos +=0;
			res = Funcs.ChessBoard(D_vert_pos, D_hor_pos);
			
			return res;
		}
		public int DD(){
			int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
			
			D_vert_pos +=2;
			D_hor_pos +=0;
			res = Funcs.ChessBoard(D_vert_pos, D_hor_pos);
			
			return res;
		}
		public int DL(){
			// int D_vert_pos = vert_pos;
			//  D_vert_pos+=1;
			int DL_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int DL_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			int res = 0;
			while (res!=2)
			{
				DL_vert_pos+=1;
				DL_hor_pos -=1;
				res = Funcs.ChessBoard(DL_vert_pos, DL_hor_pos);
			}
			
			// int D_hor_pos = Funcs.Stupid_CharToNumber(hor_pos);
			// D_hor_pos +=0;
			// hor_pos +=0;
			
			return res;
		}
		public int DR(){
			int DR_vert_pos =Funcs.Stupid_IndexReversePlusOne(Vert_pos) ;
			int DR_hor_pos = Funcs.Stupid_CharToNumber(Hor_pos);
			//  D_vert_pos+=1;
			int res = 0;
			while (res!=2)
			{
				DR_vert_pos+=1;
				DR_hor_pos +=1;
				res = Funcs.ChessBoard(DR_vert_pos, DR_hor_pos);
			}
			
			// int D_hor_pos = Funcs.Stupid_CharToNumber(hor_pos);
			// D_hor_pos +=0;
			// hor_pos +=0;
			
			return res;
		}
		public int UR(){
			int UR_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int UR_hor_pos = Funcs.Stupid_CharToNumber(Hor_pos);
			//  D_vert_pos+=1;
			int res = 0;
			while (res!=2)
			{
				UR_vert_pos-=1;
				UR_hor_pos +=1;
				res = Funcs.ChessBoard(UR_vert_pos, UR_hor_pos);
			}
			
			// int D_hor_pos = Funcs.Stupid_CharToNumber(hor_pos);
			// D_hor_pos +=0;
			// hor_pos +=0;
			
			return res;
		}
		public int UL(){
			int UL_vert_pos = Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int UL_hor_pos = Funcs.Stupid_CharToNumber(Hor_pos);
			//  D_vert_pos+=1;
			int res = 0;
			while (res!=2)
			{
				UL_vert_pos-=1;
				UL_hor_pos -=1;
				res = Funcs.ChessBoard(UL_vert_pos, UL_hor_pos);
			}
			
			// int D_hor_pos = Funcs.Stupid_CharToNumber(hor_pos);
			// D_hor_pos +=0;
			// hor_pos +=0;
			
			return res;
		}
		
		
		public int pawn_pos(){
			int p_vert_pos =Funcs.Stupid_IndexReversePlusOne(Vert_pos);
			int p_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);
			// int res_0 = Funcs.ChessBoard(p_vert_pos, p_hor_pos);
			if(p_vert_pos == 1){
				return 1;
			}
			else if(p_vert_pos == 6){
				return 2;
			}
			return 0;
		}

		

		public abstract double Mov(); 

		

	}


	public  class Funcs{

		public static int Stupid_CharToNumber(char a){
			char[] arr_ch = {'a','b','c','d','e','f','g','h'};

			for (int i = 0; i < arr_ch.Length; i++)
			{
				
				if (arr_ch[i] == a){
					return i;
				}
			}
			return 0;
		}
		public static char Stupid_NumberToChar(int s){
			char[] arr_ch = {'a','b','c','d','e','f','g','h'};

			for (int i = 0; i < arr_ch.Length; i++)
			{
				
				if (i == s){
					return arr_ch[i];
				}
			}
			return 'a';
		}

		public static int Stupid_IndexReversePlusOne(int b){
			int[] num_arr = {8,7,6,5,4,3,2,1};
			for (int i = 0; i < num_arr.Length; i++)
			{
				if(num_arr[i] == b) return i;
			}
			return 0;
		}
		public static int Stupid_IndexReverse(int b){
			int[] num_arr = {8,7,6,5,4,3,2,1};
			for (int i = 0; i < num_arr.Length; i++)
			{
				if(i == b) return num_arr[i];
			}
			return 0;
		}
		public static int ChessBoard(int m, int n){

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
				int M_converted = Stupid_IndexReverse(m);
				char N_converted = Stupid_NumberToChar(n);
				System.Console.WriteLine($"\nПозиция существует! m = {M_converted}, n = {N_converted}");
				return 1;
			}
			catch (System.Exception)
			{
				System.Console.WriteLine("\nДоска закончилась!");
				return 2;
				
			}
			
			
			

		}



	}



	public class Bishop : Figure{

		
		

		public override double Mov(){
			PrintInitial();
	
			UR();
			System.Console.WriteLine("------------------------------------------");
			
			PrintInitial();
			
			UL();
			System.Console.WriteLine("------------------------------------------");
			
			PrintInitial();
		
			DR();
			System.Console.WriteLine("------------------------------------------");
		
			PrintInitial();
	
			DL();
			
			return 0;
		}

		
	}
	public class Pawn : Figure{

// int D_vert_pos = Funcs.Stupid_IndexReversePlusOne(Figure.Vert_pos);
// 			int D_hor_pos =Funcs.Stupid_CharToNumber(Hor_pos);

		
		
		public override double Mov(){
			int res = pawn_pos();
			if(res == 1){
			PrintInitial();
			DD();
			D_pawn();
			System.Console.WriteLine("------------------------------------------");
				return 0;
			}
			else if(res == 2){
			PrintInitial();
			UU();
			U_pawn();
			System.Console.WriteLine("------------------------------------------");
			return 0;
			}
			else if(res == 0){
			PrintInitial();
			U();
			System.Console.WriteLine("------------------------------------------");
			PrintInitial();
			D();
			System.Console.WriteLine("------------------------------------------");
			}
			return 0;
		}

	}








}