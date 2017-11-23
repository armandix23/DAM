package personas;

import java.util.ArrayList;
import java.util.Scanner;

public class Menu {
	@SuppressWarnings("resource")
	public static void opciones(ArrayList<Persona> listaPersonas) {
		Scanner teclado = new Scanner(System.in);
		int opcion = 0;

		do {
			System.out.println("Menu");
			System.out.println("");
			System.out.println("1.- Escribir Fichero.");
			System.out.println("2.- Leer Fichero.");
			System.out.println("3.- Escribir Pantalla.");
			System.out.println("4.- Vaciar estructura.");
			System.out.println("5.- Modificar persona.");
			System.out.println("6.- Agregar Persona.");
			System.out.println("7.- Borrar persona.");
			System.out.println("8.- Salir.");

			opcion = teclado.nextInt();

			switch (opcion) {

			case 1:
				Funciones.escribir(listaPersonas);
				break;
			case 2:
				Funciones.leerFichero(listaPersonas);
				break;
			case 3:
				Funciones.imprimirFichero(listaPersonas);
				break;
			case 4:
				Funciones.inicializarTabla(listaPersonas);
				break;
			case 5:
				Funciones.modificarPersona(listaPersonas);
				break;
			case 6:
				Funciones.agregarPersona(listaPersonas);
				break;
			case 7:
				Funciones.borrarPersona(listaPersonas);
				break;
			case 8:
				System.out.println("Salida");
				break;
			default:
				System.out.println("Opcion no es correcta");
				//Funciones.espera();
			}
		} while (opcion != 8);
	}
}
