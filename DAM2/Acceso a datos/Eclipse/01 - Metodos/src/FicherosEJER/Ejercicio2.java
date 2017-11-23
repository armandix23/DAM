package FicherosEJER;

import java.io.*;
import java.util.Scanner;

public class Ejercicio2 {
	
	/*Pograma que cree una carpeta con el nombre que indique */

	public static void main(String[] args) {
		
		
		System.out.print("Introduzca un nombre para la carpeta: ");
	
		Scanner sc = new Scanner(System.in);
		String palabra =  sc.nextLine();
			
		File carpeta = new File(palabra);
		
		System.out.print("El nombre de la carpeta es: " +palabra + "\n");

	
			if ( carpeta.mkdir() == true) { 
				
		

	}

}
}
