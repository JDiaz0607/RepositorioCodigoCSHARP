using System;

public class Program
{
    public static void Main()
    {
//
		Console.Write("¿Cuál es el nombre del jugador? ");
		string nombre = Console.ReadLine();
		string[] nombres = new string[4];
		nombres[0] = nombre;
		Console.Write("¿que herramienta debe usar? ");
		string vida =  Console.ReadLine();
		string[] vidas = new string[4];
		vidas[0] = vida;
		Console.Write("¿cual es su color preferido? ");
		string punto = Console.ReadLine();
		string[] puntos = new string[4];
		puntos[0] = punto;
		Console.Write("¿le gusta o no el te? ");
		string legustaelte = Console.ReadLine();
		string[] LeGustaElTe = new string[4];
		LeGustaElTe[0] = legustaelte;
		Console.Write("¿le gusta o no la carne? ");
		string Legustalacarne = Console.ReadLine();
		string[] LeGustaLaCarne = new string[4];
		LeGustaLaCarne[0] = Legustalacarne;
		
//
		Console.Write("¿Cuál es el nombre del jugador? ");
		nombre = Console.ReadLine();
		nombres[1] = nombre;
		Console.Write("¿que herramienta debe usar? ");
		vida =  Console.ReadLine();
		vidas[1] = vida;
		Console.Write("¿cual es su color preferido? ");
		punto = Console.ReadLine();
		puntos[1] = punto;
		Console.Write("¿le gusta o no el te? ");
		legustaelte = Console.ReadLine();
		LeGustaElTe[1] = legustaelte;
		Console.Write("¿le gusta o no la carne? ");
		Legustalacarne = Console.ReadLine();
		LeGustaLaCarne[1] = Legustalacarne;
//
		Console.Write("¿Cuál es el nombre del jugador? ");
		nombre = Console.ReadLine();
		nombres[2] = nombre;
		Console.Write("¿que herramienta debe usar? ");
		vida = Console.ReadLine();
		vidas[2] = vida;
		Console.Write("¿cual es su color preferido? ");
		punto = Console.ReadLine();
		puntos[2] =punto;
		Console.Write("¿le gusta o no el te? ");
		legustaelte = Console.ReadLine();
		LeGustaElTe[2] = legustaelte;
		Console.Write("¿le gusta o no la carne? ");
		Legustalacarne = Console.ReadLine();
		LeGustaLaCarne[2] = Legustalacarne;
		
//
		Console.Write("¿cual es el nombre del jugador? ");
		nombre =  Console.ReadLine();
		nombres[3] = nombre;
		Console.Write("¿que herramienta debe usar? ");
		vida =  Console.ReadLine();
		vidas[3] = vida;
		Console.Write("¿cual es su color preferido? ");
		punto = Console.ReadLine();
		puntos[3] =punto;
		LeGustaElTe[3] = legustaelte;
		Console.Write("¿le gusta o no el te? ");
		legustaelte=  Console.ReadLine();
		LeGustaElTe[3] = punto;
		Console.Write("¿le gusta o no la carne? ");
		Legustalacarne = Console.ReadLine();
		LeGustaLaCarne[3] = punto;
		
		
		
		  int jugadorActual = 3;
		
		Console.WriteLine();
        Console.WriteLine("Información recibida:");
        Console.WriteLine("Nombres: {jugadorActual}"[jugadorActual]);
        Console.WriteLine("Puntos: {puntos}"[jugadorActual]);
        Console.WriteLine("Velocidad: {LeGustaElTe}"[jugadorActual]);
        Console.WriteLine("Tiene llave?: {LeGustaLaCarne}"[jugadorActual]);

		

    }
}
