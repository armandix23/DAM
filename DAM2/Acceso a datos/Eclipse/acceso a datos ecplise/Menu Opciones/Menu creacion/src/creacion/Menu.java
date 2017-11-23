package creacion;

import creacion.Funciones;

import java.util.Scanner;

public class Menu {
	public static void opciones() {
		Scanner teclado = new Scanner(System.in);

		int opcion;

		do {
			// Salida por cosola
			System.out.println("Bienvenidos al menu para asignar opciones para crear un archivo");
			System.out.println("");
			System.out.println("1.- Crear Fichero");
			System.out.println("2.- Mostrar informacion fichero.");
			System.out.println("3.- Mostrar longitud fichero.");
			System.out.println("4.- Comprobar si existe.");
			System.out.println("5.- Borrar fichero.");
			System.out.println("6.- Crear arbol de carpetas");
			System.out.println("7.- Borrar arbol de carpetas");
			System.out.println("8.- Salir.");

			opcion = teclado.nextInt();

			switch (opcion) {

			case 1: {
				Funciones.crearFichero();
				break;
			}

			case 2: {
				Funciones.mostrarInfo();
				break;
			}

			case 3: {
				Funciones.mostrarLong();
				break;
			}

			case 4: {
				Funciones.comprobar();
				break;
			}

			case 5: {
				Funciones.borrarFichero();
				break;
			}

			case 6: {
				Funciones.crearCarpetas();
				break;
			}
			
			case 7: {
				Funciones.borrarCarpetas();
				break;
			}
			
			case 8: {
				System.out.println("Salida");
				break;
			}

			default: {
				System.out.println("Opcion no es correcta");
				Funciones.espera();
			}
			}
		} while (opcion != 8);
	}
}