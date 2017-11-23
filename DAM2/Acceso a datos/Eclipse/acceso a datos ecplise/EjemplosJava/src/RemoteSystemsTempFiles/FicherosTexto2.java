package RemoteSystemsTempFiles;

import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FicherosTexto2 {

	public static void escribirFichero(String[] nombre) {
		// Escribir en un fichero.
		try {
			// 1. Crear Fichero.
			File fichero = new File("nombres.txt");
			FileWriter ficheroEscritura = new FileWriter(fichero);

			// 2. Escribir nombre.
			for (int i = 0; i < nombre.length; i++) {
				ficheroEscritura.write(nombre[i]);
			}

			// 3. Cerrar el fichero
			ficheroEscritura.close();

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void leerFichero(String[] nombres) {
		try {
			// 1.Crear Fichero.
			File fichero = new File("nombres.txt");
			FileReader ficheroLectura = new FileReader(fichero);

			// 2. Leer fichero.
			
			// 3. Cerrar fichero.
				ficheroLectura.close();

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}
	
	public static void imprimirTabla(String[] nombre) {
		System.out.println("Contenido de la tabla: ");
		for (int i = 0; i < nombre.length; i++) {
			System.out.println("Posicion " + i + " : " + nombre[i]);
		}
	}

	public static void main(String[] args) {
		String nombres = "David,Jose,Luis,Perez Pelayo,Jorge";
		String[] nombre = nombres.split(",");

		// Funciones.
		escribirFichero(nombre);
		leerFichero(nombre);
		imprimirTabla(nombre);
	}
}
