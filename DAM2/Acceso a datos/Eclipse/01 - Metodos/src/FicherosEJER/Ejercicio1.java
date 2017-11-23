package FicherosEJER;

import java.io.*;
import java.util.Scanner;

public class Ejercicio1 {
	
	/* Programa que cree un fichero con el nombre que indique el usuario*/

public static void main(String[] args) {
		
	
		System.out.print("Introduzca un nombre para el archivo: ");
	
		Scanner sc = new Scanner(System.in);
		String palabra =  sc.nextLine();
			
		File fichero = new File(palabra + ".txt");
		
		System.out.print("El nombre del archivo es: " +palabra + "\n");

		
		try {
			
			
			if ( fichero.createNewFile() == true) {
				
				System.out.println("El fichero se ha creado");
			}else {
				System.out.println("El fichero NO se ha creado");
			}
		} catch (IOException e) {
		
			e.printStackTrace();
		}
		

	}

}
