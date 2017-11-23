package FicherosEJER;

import java.io.File;
import java.io.IOException;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Ejercicio3 {

	public static void crearFichero() {
		System.out.print("Introduzca un nombre para el archivo: ");

		Scanner sc = new Scanner(System.in);
		String palabra = sc.nextLine();

		File fichero = new File(palabra + ".txt");

		System.out.print("El nombre del archivo es: " + palabra + "\n");

		try {

			if (fichero.createNewFile() == true) {

				System.out.println("El fichero se ha creado");
			} else {
				System.out.println("El fichero NO se ha creado");
			}
		} catch (IOException e) {

			e.printStackTrace();
		}
		Scanner scan = new Scanner(System.in);
		
		scan.reset();
		
	}
	
	public static void crearCarpeta(String ruta) {
		File carpeta = new File(ruta);
		
		if (carpeta.exists()) {
			System.out.println("Existe esa carpeta llamada: " +carpeta);
		} else {
			carpeta.mkdir();
		}
	}

	public static void borrarFichero() {
		System.out.print("Introduzca un nombre para el archivo: ");

		Scanner sc = new Scanner(System.in);
		String palabra = sc.nextLine();

		File fichero = new File(palabra + ".txt");
		
		System.out.println(fichero.delete());
		System.out.println("El fichero se ha borrado");
		
		Scanner scan = new Scanner(System.in);
		scan.reset();

	}

	public static void mostrarInfo() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		
		System.out.println("Informacion del fichero: ");
		System.out.println("\n");
		System.out.println(fichero.getName());
		System.out.println(fichero.getAbsolutePath());
		System.out.println(fichero.getPath());
		System.out.println(fichero.length());
		
		Scanner scan = new Scanner(System.in);
		scan.reset();
	}
	
	public static void comprobarFich() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		if (fichero.exists() == true) {
			System.out.println("El fichero existe");
		} else {
			System.out.println("El fichero no existe");
		}
		Scanner scan = new Scanner(System.in);
		scan.reset();
	}
	
	public static void longFich() {
		Scanner sc = new Scanner(System.in);
		String ruta;
		System.out.print("Introduzca el nombre del archivo creado: ");
		ruta = sc.nextLine();
		File fichero = new File(ruta + ".txt");

		System.out.println("Longitud del fichero " + fichero.getName() + " correspondiente: " + fichero.length());
		
		Scanner scan = new Scanner(System.in);
		scan.reset();
	}
	public static void crearCarpetaV1() {
		
		File directorio=new File("proyecto"); 
		directorio.mkdir(); 
		
		File directorio1=new File("proyecto/bin"); 
		directorio1.mkdir();
		
		File directorio2=new File("proyecto/src"); 
		directorio2.mkdir();
		
		File directorio3=new File("proyecto/doc"); 
		directorio3.mkdir();
		
		File directorio4=new File("proyecto/bin/bytecode"); 
		directorio4.mkdir();
		
		File directorio5=new File("proyecto/bin/objetos"); 
		directorio5.mkdir();
		
		File directorio6=new File("proyecto/src/clase"); 
		directorio6.mkdir();
		
		File directorio7=new File("proyecto/doc/html"); 
		directorio7.mkdir();
		
		File directorio8=new File("proyecto/doc/pdf"); 
		directorio8.mkdir();
		}
	
	
	public static void crearCarpetaV2() {
		
		System.out.print("Creando ruta de carpetas ");
		
		String[] link = new String[9];
		link[0] = "proyecto";
		link[1] = "proyecto/bin";
		link[2] = "proyecto/src";
		link[3] = "proyecto/doc";
		link[4] = "proyecto/bin/bytecode";
		link[5] = "proyecto/bin/objetos";
		link[6] = "proyecto/src/clase";
		link[7] = "proyecto/doc/html";
		link[8] = "proyecto/doc/pdf";
		for (int i = 0; i < link.length; i++)
			crearCarpeta(link[i]);
		
	}
	
	public static void mostrarCarpetas() {
		String Ruta = "C:\\\\Users\\\\Ar\\\\Desktop\\\\DAM\\\\DAM2\\\\Acceso a datos\\\\01 - Metodos"; // Aqui ponemos donde queremos que lea
		File f = new File(Ruta);
		
		if (f.exists()){ // Directorio si existe }
		}else { //Directorio no existe }
			System.out.print("No existe el directorio");
			}

		File[] ficheros = f.listFiles();
		for (int x = 0 ;x < ficheros.length; x++){
				System.out.println(ficheros[x].getName());
				
	
		}
		
		//limpiarPant();
	}
	
	public static void borrarCarp() {
		Scanner sc = new Scanner(System.in);
		String Directorio ;
		System.out.print("Introduzca el nombre de la carpeta a borrar: ");
		Directorio = sc.nextLine();
		File f = new File(Directorio);
		 
		if (f.exists()) {
			f.delete();
		 System.out.println("El fichero " + Directorio + " ha sido borrado correctamente");
		}else
		 System.out.println("El fichero " + Directorio + " no se ha podido borrar");
		 
	}
	/*public static void limpiarPant() {  
		
		System.out.print("\033[H\033[2J");
		System.out.flush();
	   }  */
	
	public static void main(String[] args) {

		Scanner sn = new Scanner(System.in);
		boolean salir = false;
		int opcion; // Guardaremos la opcion del usuario

		while (!salir) {

			System.out.println("1. Crear fichero");
			System.out.println("2. Mostrar fichero");
			System.out.println("3. Mostrar longitud fichero");
			System.out.println("4. Comprobar si existe");
			System.out.println("5. Borrar fichero");
			System.out.println("6. Crear estructura carpetas V1");
			System.out.println("7. Crear estructura carpetas V2");
			System.out.println("8. Recorrer arbol de directorios");
			System.out.println("9. Borrar directorios");
			System.out.println("10. Salir");

			try {

				System.out.println("Escribe el numero de una de las opciones");
				opcion = sn.nextInt();

				switch (opcion) {
				case 1:
					System.out.println("Has seleccionado la opcion 1. CREAR FICHERO");
					crearFichero();

					break;
				case 2:
					System.out.println("Has seleccionado la opcion 2. MOSTRAR INFORMACION FICHERO");
					mostrarInfo();
					break;

				case 3:
					System.out.println("Has seleccionado la opcion 3. MOSTRAR LONGITUD FICHERO");
					longFich();
					break;

				case 4:
					System.out.println("Has seleccionado la opcion 4. COMPROBAR SI EXISTE");
					comprobarFich();
					break;

				case 5:
					System.out.println("Has seleccionado la opcion 5. BORRAR FICHERO");
					borrarFichero();
					break;

				case 6:
					System.out.println("Has seleccionado la opcion 6. CREAR ESTRUCTURA CARPETAS V1");
					crearCarpetaV1();
					break;
					
				case 7:
					System.out.println("Has seleccionado la opcion 7. CREAR ESTRUCTURA CARPETAS V2");
					crearCarpetaV2();
					break;
					
				case 8:
					System.out.println("Has seleccionado la opcion 8. LEER ARBOL DE CARPETAS");
					mostrarCarpetas();
					break;
				case 9:
					System.out.println("Has seleccionado la opcion 8. BORRADO DE CARPETAS");
					borrarCarp();
					break;
				case 10:
					salir = true;
					break;

				default:
					System.out.println("Solo números entre 1 y 9");
				}
			} catch (InputMismatchException e) {
				System.out.println("Debes insertar un número");
				sn.next();
			}
		}

	}

}
