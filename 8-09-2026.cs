using System;

public class Program
{
    public static void Main()
    {

		
        Console.Write("¿Cuál es el nombre del jugador? ");
		string nombre = Console.ReadLine();
		string[] nombres = new string[3];
		nombres[0] = nombre;
		Console.Write("¿Cuál es el nombre del jugador? ");
		nombre = Console.ReadLine();
		nombres[1] = nombre;
		Console.Write("¿Cuál es el nombre del jugador? ");
		nombre = Console.ReadLine();
		nombres[2] = nombre;
		
		Console.Write("¿Cuántas vidas tiene el jugador? ");
		int vida = int.Parse(Console.ReadLine());
		int[] vidas = new int[3];
		vidas[0] = vida;
		Console.Write("¿Cuántas vidas tiene el jugador? ");
		vida = int.Parse(Console.ReadLine());
		vidas[1] = vida;
		Console.Write("¿Cuántas vidas tiene el jugador? ");
		vida = int.Parse(Console.ReadLine());
		vidas[2] = vida;
		
		Console.Write("¿Cuál es el puntaje del jugador? ");
		int punto = int.Parse(Console.ReadLine());
		int[] puntos = new int[3];
		puntos[0] = punto;
		Console.Write("¿Cuál es el puntaje del jugador? ");
		punto = int.Parse(Console.ReadLine());
		puntos[1] = punto;
		Console.Write("¿Cuál es el puntaje del jugador? ");
		punto = int.Parse(Console.ReadLine());
		puntos[2] = punto;
		
		Console.Write("¿Cuál es su Velocidad? ");
		string[] velocidad = new string[3];
		nombres[0] = "9.1f";
		nombres[1] = "6.8f";
		nombres[2] = "1.2f";
		
        Console.Write("¿Tiene llave? ");
		string[] Tienellave = new string[3];
		nombres[0] = "SI";
		nombres[1] = "NO";
		nombres[2] = "NO";
		
        Console.Write("¿Esta en la puerta? ");
		
		string[] Esta_en_la_puerta = new string[3];
		nombres[0] = "NO";
		nombres[1] = "SI";
		nombres[2] = "NO";
		int jugadorActual = 0;

        Console.WriteLine();
        Console.WriteLine("Información recibida:");
        Console.WriteLine($"Nombres: {jugadorActual}");
        Console.WriteLine($"Puntos: {jugadorActual}");
        Console.WriteLine($"Velocidad: {jugadorActual}");
        Console.WriteLine($"Tiene llave?: {jugadorActual}");
        Console.WriteLine($"Esta en la puerta?: {jugadorActual}");
		
    }
}
