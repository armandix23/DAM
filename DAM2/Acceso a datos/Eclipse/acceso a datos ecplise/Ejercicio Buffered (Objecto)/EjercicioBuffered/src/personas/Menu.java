package personas;

import java.util.Scanner;

public class Menu {
	@SuppressWarnings("resource")
	public static void opciones(Persona[] persona) {
		Scanner teclado = new Scanner(System.in);
		int opcion = 0;

		do {
			System.out.println("Menu");
			System.out.println("");
			System.out.println("1.- Escribir Fichero.");
			System.out.println("2.- Leer Fichero.");
			System.out.println("3.- Escribir Pantalla.");
			System.out.println("4.- Vaciar estructura.");
			System.out.println("8.- Salir.");

			opcion = teclado.nextInt();

			switch (opcion) {

			case 1:
				Funciones.escribir(persona);
				break;
			case 2:
				Funciones.leerFichero(persona);
				break;
			case 3:
				Funciones.imprimirFichero(persona);
				break;
			case 4:
				Funciones.inicializarTabla(persona);
				break;
			case 8:
				System.out.println("Salida");
				break;
			default:
				System.out.println("Opcion no es correcta");
				Funciones.espera();
			}
		} while (opcion != 8);
	}
}
