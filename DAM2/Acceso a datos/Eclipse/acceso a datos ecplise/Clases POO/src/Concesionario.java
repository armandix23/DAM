
public class Concesionario {

	// Ordenar los coches por caballos
	public static void ordenarCaballos(Coche C1, Coche C2, Coche C3) 
	{
		if (C1.getnCaballos() < C2.getnCaballos() && C1.getnCaballos() < C3.getnCaballos()) {
			if(C2.getnCaballos()< C3.getnCaballos()) 
			{
				System.out.println(C1.estado());
				System.out.println(C2.estado());
				System.out.println(C3.estado());
			}else 
			{
				System.out.println(C1.estado());
				System.out.println(C3.estado());
				System.out.println(C2.estado());
			}
		}else if (C2.getnCaballos() < C3.getnCaballos()) 
		{
			if(C1.getnCaballos() < C3.getnCaballos()) 
			{
				System.out.println(C2.estado());
				System.out.println(C1.estado());
				System.out.println(C3.estado());
			}else 
			{
				System.out.println(C2.estado());
				System.out.println(C3.estado());
				System.out.println(C1.estado());
			}
		}else 
			if(C1.getnCaballos()< C2.getnCaballos()) 
			{
				System.out.println(C1.estado());
				System.out.println(C2.estado());
				System.out.println(C3.estado());
			}else 
			{
				System.out.println(C3.estado());
				System.out.println(C2.estado());
				System.out.println(C1.estado());
			}
	}
	
	public static void comprobarParados(Coche C1, Coche C2, Coche C3) 
	{
		if(C1.getDireccion() == "Parado") 
		{
			C1.setMarcha(0);
		}
		
		if(C2.getDireccion() == "Parado") 
		{
			C2.setMarcha(0);
		}
		
		if(C3.getDireccion() == "Parado") 
		{
			C3.setMarcha(0);
		}
	}

	public static void main(String[] args) {
		// Creamos un OBJETO llamado C1 el constructor inicializa las variables
		Coche C1 = new Coche(120, "Parado", 2, "2810HNT");
		Coche C2 = new Coche(150, "Delante", -1, "3322DFC");
		Coche C3 = new Coche(230, "Atras", -1, "2323dde");
		
		ordenarCaballos(C1, C2, C3);
		comprobarParados(C1, C2, C3);
		
		System.out.println(C1.estado());
		System.out.println(C2.estado());
		System.out.println(C3.estado());
		
	}
}
