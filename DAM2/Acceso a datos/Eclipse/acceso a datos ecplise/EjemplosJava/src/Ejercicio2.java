import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class Ejercicio2 {

	// 2. Programa cree una carpeta con el nombre que indique.

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca texto: ");
		ruta = sc.nextLine();

		File fichero = new File(ruta); // Creamos la variable llamada fichero y le agregamos la ruta
		// del fichero

		if (fichero.mkdir() == true) {
			System.out.println("La carpeta se ha creado");
		} else {
			System.out.println("La carpeta no existe o se ha creado");
		}
	}
}
