package actividad3;

import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

/* Crear una clase para gestionar Productos de una tienda de informatica, que se define
   por nombre y precio. Tendra que contener las siguientes operaciones: rebajar el precio, 
   aumentar el precio. Completar con:

	- Programa principal que cree 4 Productos, lea el contenido de los productos de un  fichero
	  de texto, aumente 10% el precio del 1 producto, disminuya un 20% el precio del 2 producto
	  y escriba por pantalla los datos de los 4 productos.
*/

public class Principal {

	public static void main(String[] args) {
		Productos[] tabla = new Productos[4];

		// Creamos los productos.

		for (int i = 0; i < tabla.length; i++)
			tabla[i] = new Productos();

		// Leer el fichero:
		// Formato Nombre1;Precio1;Nombre2;Precio2;
		// Nombre3;Precio3;Nombre4;Precio4;

		try {
			File fichero = new File("productos.txt");
			@SuppressWarnings("resource")
			FileReader ficheroR = new FileReader(fichero);
			char[] cadena = new char[1];
			int contador = 0, Nproducto = 0, resultado = 0;
			
			String valor = "";
			String nombreA = "";
			String precioA = "";

			resultado = ficheroR.read(cadena);
			while (resultado != -1) {
				if (cadena[0] != ';')
					valor += cadena[0];
				else {
					if (contador % 2 == 0) // Nombre
						nombreA = valor;
					else {
						precioA = valor;
						tabla[Nproducto].setNombre(nombreA);
						tabla[Nproducto].setPrecio(Integer.parseInt(precioA));
						nombreA = "";
						precioA = "";
						Nproducto++;
					}
					valor = "";
					contador++;
				}
				resultado = ficheroR.read(cadena);
			}
			precioA = valor;
			tabla[Nproducto].setNombre(nombreA);
			tabla[Nproducto].setPrecio(Integer.parseInt(precioA));

			// Aumentar, disminuir los productos.

			tabla[0].aumentar(10);
			tabla[1].disminuir(20);

			// Imprimir valores

			for (int i = 0; i < tabla.length; i++) {
				System.out.println(tabla[i].imprimir());
			}

		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
	}
}
