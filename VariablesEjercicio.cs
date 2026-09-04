using System;

class Program
{
    static void Main()
    {
		// Variables del personaje
        string nombre = "Jack";
        int vidas = 0;
		int puntos = 100;
        float velocidad = 1.3f;
		bool tienellave = true;
		bool EstaEnLaPuerta = false;
		
		// Variables booleanas
		bool estaVivo = vidas >0 ;
		bool estaMuerto = !estaVivo;
		
		bool puedeAbrir = tienellave && EstaEnLaPuerta;
		
		bool puedeAvanzarNivel = estaVivo && puntos >= 100;
		
		Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Vidas: " + vidas);
        Console.WriteLine("puntos: " + puntos);
		Console.WriteLine("tienellave: " + tienellave);
		Console.WriteLine("EstaEnLaPuerta: " + EstaEnLaPuerta);
		Console.WriteLine("Velocidad: " + velocidad);
			
        velocidad = velocidad + 2.0f;
		Console.WriteLine("estaVivo: " + estaVivo);
		Console.WriteLine("puedeAbrir: " + puedeAbrir);
		Console.WriteLine("puedeAvanzarNivel: " + puedeAvanzarNivel);
		
    }
}
