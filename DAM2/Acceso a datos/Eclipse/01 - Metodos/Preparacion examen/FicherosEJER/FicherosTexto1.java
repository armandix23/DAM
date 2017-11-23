package FicherosEJER;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class FicherosTexto1 {
	
	public static void escribirFichero(String[] lista) {
	

		try {

			/* 1. Crear fichero */
			File fichero = new File("FicheroNombres.txt");
			FileWriter ficheroEscritura = new FileWriter(fichero);

			/* 2. Escribir nombres */
			for (int i = 0; i < lista.length; i++) {
				ficheroEscritura.write(lista[i]);
				if(i!=lista.length-1)
					ficheroEscritura.write(";");
			}
				/* Cerrar fichero */
				ficheroEscritura.close();
			
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	public static void inicializarChar(char[] tabla) {
		
		for(int i = 0; i < tabla.length; i++) 
			tabla[i] = '\0';
		
	}
	
	public static void leerFichero(String[] lista) {
	try {
			
		/* 1. Crear fichero */
		File fichero = new File("FicheroNombres.txt");
		FileReader ficheroLectura = new FileReader(fichero);
		
		/* 2. Leer nombres */
		char[] nombre = new char[4];
		int res, i = 0;
		String cadenaFichero= "";
		inicializarChar(nombre);
		res = ficheroLectura.read(nombre);
		
		while(res != -1) {
			
			/*Tratar la cadena*/
			cadenaFichero = cadenaFichero + String.valueOf(nombre); // Coonversion de char a string /// Mete todos los nombres en un string entero
			inicializarChar(nombre);
			res = ficheroLectura.read(nombre);
			i++;
		}
	
		/* Cerrar fichero */
		ficheroLectura.close();
		//lista = cadenaFichero.split(";");
		imprimirTabla(cadenaFichero);
	}
	catch (IOException e) {
		e.printStackTrace();
	}
	
}
	
	
	public static void imprimirTabla(String cadenaFichero) {
		
		String[] lista = cadenaFichero.split(";");
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
		
		String[] lista = { "Pepe", "Anita ", "Juan", "Jose luis del barco mis co" };
		
		escribirFichero(lista);
		
		inicializarTabla(lista);
		
		leerFichero(lista);
		
		
		
		
	}
}
