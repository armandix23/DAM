package personas;

import java.util.ArrayList;
import java.util.Scanner;

/*

 * Este es el ejercicio3

 * Creado por David Román Rey

 * github: https://github.com/Davilin28

*/

public class Principal {

	public static void main(String[] args) {

		Scanner leer = new Scanner(System.in);
		int numeroPersonas = 1;
		ArrayList<Persona> listaPersonas = new ArrayList<Persona>();
		
		for (int i = 0; i < numeroPersonas; i++) {
			Persona persona = new Persona(); // Creamos una persona
			System.out.println("Escribir Nombre: " + i);
			persona.setNombre(leer.nextLine());
			System.out.println("Escribir Apellido " + i);
			persona.setApellidos(leer.nextLine());
			System.out.println("Escribir Edad " + i);
			persona.setEdad(Integer.parseInt(leer.nextLine()));
			listaPersonas.add(persona);
		}

		Menu.opciones(listaPersonas);
	}
}
