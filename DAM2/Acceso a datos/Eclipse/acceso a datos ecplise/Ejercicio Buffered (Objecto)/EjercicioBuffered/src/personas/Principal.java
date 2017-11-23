package personas;

/*

 * Este es el ejercicio3

 * Creado por David Román Rey

 * github: https://github.com/Davilin28

*/

public class Principal {

	public static void main(String[] args) {

		Persona persona[] = new Persona[5];
		persona[0] = new Persona("Ana", "Rodriguez", 22);
		persona[1] = new Persona("Luis", "Perez", 33);
		persona[2] = new Persona("David", "Garcia", 40);
		persona[3] = new Persona("Jose", "del Bosque", 18);
		persona[4] = new Persona("Rodrigo", "Marquez", 20);

		Menu.opciones(persona);
	}
}
