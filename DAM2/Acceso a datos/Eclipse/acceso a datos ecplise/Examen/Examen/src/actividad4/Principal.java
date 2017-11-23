package actividad4;

import java.io.File;
import java.io.IOException;
import java.util.Scanner;

/*	Crear un programa que lea 10 numeros, crea una carpeta llamada numeros en el directorio actual
 	y dentro de esta carpeta crea un fichero por cada numero introducido
 */

public class Principal {

	public static void main(String[] args) {
		File carpeta = new File("numeros");
		Scanner scan = new Scanner(System.in);
		File fichero;
		int numero = 0;

		// Crear carpeta numeros
		try {
			carpeta.mkdir();
			for (int i = 0; i < 10; i++) {
				System.out.println("Introduce numero: ");
				numero = scan.nextInt();
				fichero = new File("numeros\\" + numero + ".txt");
				fichero.createNewFile();
				}
			scan.close();
			}catch (IOException ex) {
			System.out.println(ex.getMessage());
			ex.printStackTrace();
		}
	}
}
