package paquetes;

import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class Funciones {

	// Funcion para escribir dentro del fichero.
	public static void escribirFichero(String[] nombres) {
		try {
			// 1.Creamos el fichero y escribimos en el
			File datos = new File("nombres.txt");
			FileWriter ficheroEscritura = new FileWriter(datos);

			// 2. Insertamos los datos dentro del fichero recorriendolo con un for.
			for (int i = 0; i < nombres.length; i++) {
					ficheroEscritura.write(nombres[i]);
					if (i!=nombres.length-1)
						ficheroEscritura.write(';');
			}

			// 3. Cerrar el fichero
			ficheroEscritura.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// Funcion para leer el fichero y sacarlo por pantalla.
	public static void leerFichero(String[] nombres) {
		try {
			// 1.Creamos el fichero y lo leemos
			File datos = new File("nombres.txt");
			FileReader ficheroLectura = new FileReader(datos);
			
			// 2. leer el fichero letra a letra 
			char[] nombre = new char[1];
			int res;
			String cadenaCompleta = "";
			res = ficheroLectura.read(nombre);
			
			while(res !=  -1) {
				// Convierte el char en un String
				cadenaCompleta += String.valueOf(nombre);
				res = ficheroLectura.read(nombre);
			}
			
			// 3. Cerramos el fichero
			ficheroLectura.close();
			
			// Llamamos a la funcion para que nos imprima la cadenaCompleta
			imprimirFichero(cadenaCompleta);
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	// Imprimir los datos
	public static void imprimirFichero(String cadenaCompleta) {
		
		// El split lo que hace es separarte cada nombre cuando encuentre un ";"
		// En este paso lo que haces es convierteme la cadenaCompleta separada por ";" en un array de String
		// y recorrela con un for hasta la longitud de complete
		String[] complete = cadenaCompleta.split(";");
		System.out.println("Contenido de la tabla: ");
		System.out.println("");
		for(int i=0;i<complete.length;i++)
			System.out.println("Posicion " + i + " : " + complete[i]);
		}
	
	// Inicializar la tabla cuando hagamos la escritura para evitar posibles confusiones a la hora de leerlo
	// e imprimirlo
	public static void inicializarTabla(String[] nombres) {
		for (int i = 0; i < nombres.length; i++) {
			nombres[i]="";
		}
	}
}