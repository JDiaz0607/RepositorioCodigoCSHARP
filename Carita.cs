using System;
					
public class Program
{
	public static void Main()
	{
		//
		string linea1= "xxxxxxxx";
		string linea2= "";
		string linea3= "";
		
		string[] lineaA2= {"x","o","x","o","x"};
		int[] linea2R= {2 ,1 ,2 ,1 ,2};

		string[] lineaA3= {"x","(","-",")","x"};
		int[] linea3R= {2 ,1 ,2 ,1 ,2};
		
		//
		for ( int i = 0 ; i > 8 ; i++){
			linea1 += "x";
		}
		
		//
		for (int j=0 ; j < lineaA2.Length; j++){
			string L= lineaA2 [j];
			int rep= linea2R [j];
	
			for (int k=0; k<rep; k++){
				linea2 += L;
			}
		}
		
		//
		for (int j=0 ; j < lineaA2.Length; j++){
			string L2= lineaA3 [j];
			int rep2= linea3R [j];
	
			for (int k=0; k<rep2; k++){
				linea3 += L2;
			}
		}
		//
		Console.WriteLine(linea1);
		Console.WriteLine(linea2);
		Console.WriteLine(linea3);
	}
}
