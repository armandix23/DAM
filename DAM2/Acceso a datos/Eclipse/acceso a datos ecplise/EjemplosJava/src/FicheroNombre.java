import java.io.File;
import java.io.IOException;
import java.util.Scanner;

public class FicheroNombre {

	// 1. Un programa que cree un fichero el nombre que indique.

	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca texto: ");
		ruta = sc.nextLine();

		File fichero = new File(ruta+".txt"); // Creamos la variable llamada fichero y le agregamos la ruta
		// del fichero

		// Solo se usa para excepciónes que creamos que puedan dar algun fallo.
		try {
			if (fichero.createNewFile() == true) {
				System.out.println("El fichero se ha creado");
			} else {
				System.out.println("El fichero no se ha creado o esta creado");
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
