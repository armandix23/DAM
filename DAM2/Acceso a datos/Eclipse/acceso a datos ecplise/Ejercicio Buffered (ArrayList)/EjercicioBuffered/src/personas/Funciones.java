package personas;

import java.io.*;
import java.util.ArrayList;
import java.util.Scanner;

public class Funciones {
	public static void escribir(ArrayList<Persona> listaPersonas) {
		try {
			// 1.Creamos el fichero y escribimos en el
			File datos = new File("nombres.txt");
			FileWriter ficheroEscritura = new FileWriter(datos);
			BufferedWriter ficheroBuffer = new BufferedWriter(ficheroEscritura);

			// 2. Insertamos los datos dentro del fichero recorriendolo con un for.
			for (int i = 0; i < listaPersonas.size(); i++) {
				ficheroBuffer.write(listaPersonas.get(i).getNombre() + "\n" + listaPersonas.get(i).getApellidos() + "\n"
						+ listaPersonas.get(i).getEdad());
				ficheroBuffer.newLine();
			}

			// 3. Cerrar el fichero
			ficheroBuffer.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void leerFichero(ArrayList<Persona> listaPersonas) {
		try { //
				// 1.Creamos el fichero y lo leemos
			File datos = new File("nombres.txt");
			FileReader ficheroLectura = new FileReader(datos);
			BufferedReader bufferedRead = new BufferedReader(ficheroLectura);

			// 2. leer nombres con String, cuando read devuelve un null se ha llegado //
			// al final del fichero.

			int i = 0;
			String lineas;
			lineas = bufferedRead.readLine();

			while (lineas != null) {
				listaPersonas.get(i).setNombre(lineas);
				lineas = bufferedRead.readLine();
				listaPersonas.get(i).setApellidos(lineas);
				lineas = bufferedRead.readLine();
				listaPersonas.get(i).setEdad(Integer.parseInt(lineas));
				i++;
				lineas = bufferedRead.readLine();
			}

			// 3. Cerramos el fichero ficheroLectura.close();

		} catch (IOException e) { // TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

	public static void imprimirFichero(ArrayList<Persona> listaPersonas) {
		System.out.println("Contenido de la tabla: ");
		System.out.println("");
		for (int i = 0; i < listaPersonas.size(); i++) {// ahora imprimiremos las personas de nuestro ArrayList
			System.out.println("Persona numero " + i);
			Persona persona = (Persona) listaPersonas.get(i);
			System.out.println("Nombre: " + persona.getNombre() + " Apellidos: " + persona.getApellidos() + " Edad: "
					+ persona.getEdad());
		}
		espera();
	}

	public static void inicializarTabla(ArrayList<Persona> listaPersonas) {
		for (int i = 0; i < listaPersonas.size(); i++) {
			listaPersonas.get(i).setNombre("");
			listaPersonas.get(i).setApellidos("");
			listaPersonas.get(i).setEdad(0);
		}
	}

	public static void modificarPersona(ArrayList<Persona> listaPersonas) {
		Scanner seleccionar = new Scanner(System.in);
		Scanner leer = new Scanner(System.in);
		imprimirPosicion(listaPersonas);
		System.out.println("Modificar usuario: ");
		int opcion = 0;
		opcion = seleccionar.nextInt();
		
		System.out.println("Escribir Nombre: ");
		listaPersonas.get(opcion).setNombre(leer.nextLine());
		System.out.println("Escribir Apellido ");
		listaPersonas.get(opcion).setApellidos(leer.nextLine());
		System.out.println("Escribir Edad ");
		listaPersonas.get(opcion).setEdad(Integer.parseInt(leer.nextLine()));
	}

	public static void agregarPersona(ArrayList<Persona> listaPersonas) {
		Scanner leer = new Scanner(System.in);
		Persona persona = new Persona();
		System.out.println("Agregar usuario: ");
		System.out.println("Escribir Nombre: ");
		persona.setNombre(leer.nextLine());
		System.out.println("Escribir Apellido ");
		persona.setApellidos(leer.nextLine());
		System.out.println("Escribir Edad ");
		persona.setEdad(Integer.parseInt(leer.nextLine()));
		listaPersonas.add(persona);
	}

	public static void borrarPersona(ArrayList<Persona> listaPersonas) {
		Scanner seleccionar = new Scanner(System.in);
		imprimirPosicion(listaPersonas);
		System.out.println("Que usuario desea eliminar: ");
		int opcion = 0;
		opcion = seleccionar.nextInt();
		listaPersonas.remove(opcion);
	}
	
	public static void imprimirPosicion(ArrayList<Persona> listaPersonas) {
		for(int i=0;i<listaPersonas.size();i++)
			System.out.println("Usuario: "+ i + " "+listaPersonas.get(i).getNombre());
	}

	public static void espera() {
		try {
			Thread.sleep(2500);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
	}
}
