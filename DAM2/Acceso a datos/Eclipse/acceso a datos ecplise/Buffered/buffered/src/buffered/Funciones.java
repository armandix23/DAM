package buffered;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Funciones {
	public static void escribirFichero(String[] nombres) {
		try {
			// 1.Creamos el fichero y escribimos en el
			File datos = new File("nombresas.txt");
			FileWriter ficheroEscritura = new FileWriter(datos);
			BufferedWriter ficheroBuffer = new BufferedWriter(ficheroEscritura);

			// 2. Insertamos los datos dentro del fichero recorriendolo con un for.
			for (int i = 0; i < nombres.length; i++) {
				ficheroBuffer.write(nombres[i]);
				ficheroBuffer.newLine();
			}

			// 3. Cerrar el fichero
			ficheroBuffer.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// Funcion para leer el fichero y sacarlo por pantalla.
	public static void leerFichero(String[] nombres) {
		try {
			// 1.Creamos el fichero y lo leemos
			File datos = new File("nombresas.txt");
			FileReader ficheroLectura = new FileReader(datos);
			BufferedReader bufferedRead = new BufferedReader(ficheroLectura);

			// 2. leer nombres con String, cuando read devuelve un null se ha llegado
			// al final del fichero.

			int i = 0;
			String lineas;
			lineas = bufferedRead.readLine();

			while (lineas != null) {
				nombres[i] = lineas;
				i++;
				lineas = bufferedRead.readLine();
			}

			// 3. Cerramos el fichero
			ficheroLectura.close();

		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// Imprimir los datos
	public static void imprimirFichero(String[] nombres) {
		System.out.println("Contenido de la tabla: ");
		System.out.println("");
		for (int i = 0; i < nombres.length; i++)
			System.out.println("Posicion " + i + " : " + nombres[i]);
	}

	// Inicializar la tabla cuando hagamos la escritura para evitar posibles
	// confusiones a la hora de leerlo
	// e imprimirlo
	public static void inicializarTabla(String[] nombres) {
		for (int i = 0; i < nombres.length; i++) {
			nombres[i] = "";
		}
	}
}
