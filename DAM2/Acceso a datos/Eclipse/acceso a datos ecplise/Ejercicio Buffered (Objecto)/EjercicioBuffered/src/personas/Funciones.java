package personas;

import java.io.*;

public class Funciones {
	public static void escribir(Persona[] persona) {
		try {
			// 1.Creamos el fichero y escribimos en el
			File datos = new File("nombres.txt");
			FileWriter ficheroEscritura = new FileWriter(datos);
			BufferedWriter ficheroBuffer = new BufferedWriter(ficheroEscritura);

			// 2. Insertamos los datos dentro del fichero recorriendolo con un for.
			for (int i = 0; i < persona.length; i++) {
				ficheroBuffer.write(persona[i].getNombre() + "\n" + persona[i].getApellidos() + "\n"
						+ String.valueOf(persona[i].getEdad()));
				ficheroBuffer.newLine();
			}

			// 3. Cerrar el fichero
			ficheroBuffer.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void leerFichero(Persona[] persona) {
		try {
			// 1.Creamos el fichero y lo leemos
			File datos = new File("nombres.txt");
			FileReader ficheroLectura = new FileReader(datos);
			BufferedReader bufferedRead = new BufferedReader(ficheroLectura);

			// 2. leer nombres con String, cuando read devuelve un null se ha llegado
			// al final del fichero.

			int i = 0;
			String lineas;
			lineas = bufferedRead.readLine();

			while (lineas != null) {
				persona[i].setNombre(lineas);
				lineas = bufferedRead.readLine();
				persona[i].setApellidos(lineas);
				lineas = bufferedRead.readLine();
				persona[i].setEdad(Integer.parseInt(lineas));
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

	public static void imprimirFichero(Persona[] persona) {
		System.out.println("Contenido de la tabla: ");
		System.out.println("");
		for (int i = 0; i < persona.length; i++) {
			String laedad = String.valueOf(persona[i].getEdad());
			if (laedad.equals("0")) {
				System.out.println("Nombre: " + persona[i].getNombre() + " Apellidos: "
						+ persona[i].getApellidos() + " Edad: ");
			} else {
				System.out.println("Nombre: " + persona[i].getNombre() + " Apellidos: "
						+ persona[i].getApellidos() + " Edad: " + String.valueOf(persona[i].getEdad()));
			}
		}
		espera();
	}

	public static void inicializarTabla(Persona[] persona) {
		for (int i = 0; i < persona.length; i++) {
			persona[i].setNombre("");
			persona[i].setApellidos("");
			persona[i].setEdad(0);
		}
	}

	public static void espera() {
		try {
			Thread.sleep(2500);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
}
