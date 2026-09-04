using System;

class Program
{
    static void Main()
    {
		
		string[] nombres = { "Jason", "Freddy", "Michael", "Sarah","Ana" };
		int[] vidas = { 3, 6, 1, 9,5 };
		int[] puntos = { 100,40,10,65,90};
		float[] velocidad = {3.5f,6.7f,1.2f,4.9f,7.8f};
		bool[] tienellave = {true,false,false,true,true};
		bool[] EstaEnLaPuerta = {false,true,false,false,true};
		int jugadorActual = 0;
		
		Console.WriteLine("Nombres: " + nombres [jugadorActual]);
		Console.WriteLine("Vidas: " + vidas [jugadorActual]);
		Console.WriteLine("Puntos: " + puntos [jugadorActual]);
		Console.WriteLine("Velocidad: " + velocidad [jugadorActual]);
		Console.WriteLine("Tiene llave: " + tienellave [jugadorActual]);
		Console.WriteLine("Esta en la puerta: " + EstaEnLaPuerta [jugadorActual]);
    }
}
