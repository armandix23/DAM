public class MetodosClase {
	
public static Fecha crearFecha() {
	
	Fecha f = new Fecha();
	return f;
	
}

	public static void main(String[] args) {

	int numero;
	String nombre = "pepe";
	Fecha f1,f2;
	
	
	
	f1= new Fecha();
	//f2 = new Fecha();
	
	f2 = f1;
	
	f1.setDia(1);
	f1.setMes(1);
	f1.setAnio(1);
	
	f2.setDia(2);
	f2.setMes(2);
	f2.setAnio(2);
		
	
	System.out.println(f1.escribeCorto());
	System.out.println(f2.escribeCorto());
	
	
	}

}


/* COMO CREAR UN METODO
 * 
 * 1. Crear variable 
 * 2. Instanciar variable */