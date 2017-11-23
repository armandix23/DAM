import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FicherosTexto1 {

	public static void escribirFichero(String[] lista) {
		// Escribir en un fichero.

		try {
			// 1. Crear Fichero.
			File fichero = new File("FicheroNombres.txt");
			FileWriter ficheroEscritura = new FileWriter(fichero);

			// 2. Escribir nombre.
			for (int i = 0; i < lista.length; i++) {
				ficheroEscritura.write(lista[i]);
			}

			// 3. Cerrar el fichero
			ficheroEscritura.close();

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void leerFichero(String[] lista) {

		try {
			// 1.Crear Fichero.
			File fichero = new File("FicheroNombres.txt");
			FileReader ficheroLectura = new FileReader(fichero);

			// 2. Leer fichero.
			char[] nombre = new char[4];
			int res, i=0;
				res = ficheroLectura.read(nombre);
				while(res != -1) {
					lista[i] = String.valueOf(nombre);
					res = ficheroLectura.read(nombre);
					i++;
					}
			// 3. Cerrar fichero.
				ficheroLectura.close();

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

	public static void imprimirTabla(String[] lista) {
		System.out.println("Contenido de la tabla: ");
		for (int i = 0; i < lista.length; i++) {
			System.out.println("Posicion " + i + " : " + lista[i]);
		}
	}
	
	public static void inicializarTabla(String[] lista) {
		for (int i = 0; i < lista.length; i++) {
			lista[i]="";
		}
	}

	public static void main(String[] args) {
		String[] lista = {"Pepe","Ana","Juan"};
	
		escribirFichero(lista);
		inicializarTabla(lista);
		leerFichero(lista);
		imprimirTabla(lista);
	}
}
