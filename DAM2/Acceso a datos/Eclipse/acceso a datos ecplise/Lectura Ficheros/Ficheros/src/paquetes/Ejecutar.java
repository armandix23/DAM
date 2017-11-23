package paquetes;

/*

 * Ejercicio de Escritura y Lectura de ficheros

 * Creado por David Román Rey

 * github: https://github.com/Davilin28

*/

public class Ejecutar {

	public static void main(String[] args) {
		
		String[] nombres = {"Jose","Pepe","Ana","Luis Alberto","Jose Luis"};
		
		Funciones.escribirFichero(nombres);
		Funciones.inicializarTabla(nombres);
		Funciones.leerFichero(nombres);
	}
}