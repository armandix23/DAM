import java.io.*;

public class CrearFicheros {

	public static void main(String[] args) {

		File fichero = new File("RutaTexto.txt"); // Creamos la variable llamada fichero y le agregamos la ruta
													// del fichero

		// Solo se usa para excepciónes que creamos que puedan dar algun fallo.
		try {
			if(fichero.createNewFile() == true) {
				System.out.println("El fichero se ha creado");
			}else {
				System.out.println("El fichero no se ha creado o esta creado");
			}
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

	}

}
