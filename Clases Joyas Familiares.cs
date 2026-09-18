using System;
					
class Escenarios
{
    public string Ubicacion;
    private string Descripcion;
	private int Pistas;
	private int Npcs;
	
    public void AsignarEscenario(int Escenaelegida)
    {

        if (Escenaelegida==1)
        	{
				Ubicacion = "Mansion";
				Descripcion= "aa";
				Pistas= 6;
				Npcs= 5;
        	}
        else if (Escenaelegida==2)
        	{
				Ubicacion = "Joyeria";
				Descripcion="";
				Pistas= 5;
				Npcs= 2;
			}
		else if (Escenaelegida==3)
			{
				Ubicacion = "Comisaria";
				Descripcion="Una estacon de policia de dos pisos";
				Pistas= 2;
				Npcs= 4;
			}
		else
        {
            Console.WriteLine("Numero invalido. Debes elegir 1, 2 o 3.");
				Ubicacion = "Ninguno";
				Descripcion="Ninguno";
				Pistas= 0;
				Npcs= 0;
        }
		
	}
public void Mostrarescenario()
    {
        Console.WriteLine($"Locacion elegida: {Ubicacion}");
        Console.WriteLine($"Descipcion del lugar: {Descripcion}");
        Console.WriteLine($"Pistas en el escenario actual: {Pistas}");
        Console.WriteLine($"Personas en la zona: {Npcs}");
    }

    public static void Main()
	{
		Console.WriteLine("Elije un escenario");
		string escena = Console.ReadLine();
		int opcion = int.Parse(escena);
		
		Escenarios Escenas1 = new Escenarios();
        Escenas1.AsignarEscenario(opcion);
        Escenas1.Mostrarescenario();
	}
}
