using System;

public class Program
{
    delegate void Evento();

    static void EncontrarMoneda()
    {
        Console.WriteLine("Encontraste una moneda de oro brillante.");
    }

    static void EncontrarTrampa()
    {
        Console.WriteLine("¡Cuidado! Pisaste una trampa y pierdes 10 de vida.");
    }

    static void EncontrarPocion()
    {
        Console.WriteLine("Encontraste una poción de curación.");
    }
	static void EncontrarCopa()
	{
		
	}
	static void EncontrarLlave()
	{
		Console.WriteLine("Encontraste una llave");
	}

    static void EjecutarEventoAleatorio(Evento[] eventos)
    {
        Random rnd = new Random();
        int indice = rnd.Next(eventos.Length);
        eventos[indice]();
    }

    public static void Main()
    {
        Evento[] posibles = { EncontrarMoneda, EncontrarTrampa, EncontrarPocion, EncontrarCopa };

        Console.WriteLine("Entras al bosque...");
        EjecutarEventoAleatorio(posibles);
    }
}
