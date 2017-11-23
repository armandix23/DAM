package creacion;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Funciones {
	// Funcion Crear fichero
	public static void crearFichero() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Indicar el nombre del archivo (sin extension): ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		try {
			if (fichero.createNewFile() == true) {
				System.out.println("El fichero se ha creado");
			} else {
				System.out.println("El fichero no se ha creado o esta creado");
			}
			espera();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	// Funcion para ver la info del fichero.
	public static void mostrarInfo() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		// Salida por cosola
		System.out.println("Informacion del fichero: ");
		System.out.println("");
		System.out.println(fichero.getName());
		System.out.println(fichero.getAbsolutePath());
		System.out.println(fichero.getPath());
		System.out.println(fichero.length());
		espera();
	}

	// Funcion para mostrar la longitud del archivo.
	public static void mostrarLong() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		// Salida por cosola
		System.out.println("Longitud del fichero " + fichero.getName() + " correspondiente: " + fichero.length());
		espera();
	}

	// Funcion para comprobar si existe el archivo.
	public static void comprobar() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		// Salida por cosola
		if (fichero.exists() == true) {
			System.out.println("El fichero existe");
		} else {
			System.out.println("El fichero no existe");
		}
		espera();
	}

	// Funcion para borrar el fichero.
	public static void borrarFichero() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		// Salida por cosola
		if (fichero.delete()) {
			System.out.println("El fichero se ha borrado correctamente");
		} else {
			System.out.println("El fichero no existe");
		}
		espera();
	}

	// Funcion para crear carpetas automaticas
	public static void crearCarpetas() {
		String[] ruta = new String[9];
		ruta[0] = "proyecto";
		ruta[1] = "proyecto/bin";
		ruta[2] = "proyecto/src";
		ruta[3] = "proyecto/doc";
		ruta[4] = "proyecto/bin/bytecode";
		ruta[5] = "proyecto/bin/objetos";
		ruta[6] = "proyecto/src/clase";
		ruta[7] = "proyecto/doc/html";
		ruta[8] = "proyecto/doc/pdf";
		for (int i = 0; i < ruta.length; i++)
			crear(ruta[i]);
		mensaje();
		espera();
	}

	// Funcion llamada por crearCarpeta
	public static void crear(String ruta) {
		File carpeta = new File(ruta);

		if (carpeta.exists()) {
			System.out.println("Existe esa carpeta llamada: " + carpeta);
		} else {
			carpeta.mkdir();
		}
	}

	// Mensaje que su proceso se activa cuando termina crearCarpeta
	public static void mensaje() {
		System.out.println("Se ha creado correctamente ");
	}

	// Solo borra las subcarpetas por ejemplo:
	// Si pones proyecto/bin/objetos te lo elimina.
	// Si pones proyecto solo al ser el padre no lo elimina

	public static void borrarCarpetas() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca la ruta de la carpeta que desea eliminar: ");
		ruta = sc.nextLine();
		File carpeta = new File(ruta);

		if (carpeta.exists()) {
			carpeta.delete();
			System.out.println("carpeta borrada");
		} else {
			System.out.println("No existe la carpeta llamada: " + carpeta);
		}
		espera();
	}

	// Funcion para tiempo de espera entre opciones
	public static void espera() {
		try {
			Thread.sleep(2500);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
}
