package FicherosEJER;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FicherosTexto2 {
	
	public static void escribirFichero(String[] lista) {
	

		try {

			/* 1. Crear fichero */
			File fichero = new File("FicheroNombres.txt");
			FileWriter ficheroEscritura = new FileWriter(fichero);

			/* 2. Escribir nombres */
			for (int i = 0; i < lista.length; i++) {
				ficheroEscritura.write(lista[i]);
			}
				/* Cerrar fichero */
				ficheroEscritura.close();
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void leerFichero(String[] lista) {
		
		
		
		System.out.println(lista.length);
		
	}
	public static void imprimirTabla(String[] lista) {
		
		System.out.println("Contenido de la tabla");
		for(int i=0;i<lista.length;i++) {
			System.out.println("Posicion "+ i +"  : " +lista[i]);
			}
	}
	public static void inicializarTabla(String[] lista) {
		for(int i=0;i<lista.length;i++) {
			lista[i]="";
			}
	}

	public static void main(String[] args) {
		
		String[] lista = { "Pepe", "Ana", "Juan", "Carles", "Rufoenl" };
		
		escribirFichero(lista);
		
		inicializarTabla(lista);
		
		leerFichero(lista);
		
		imprimirTabla(lista);
		
		
	}
}
