package buffered;

public class BufferedT {

	public static void main(String[] args) {
		String[] nombres = { "Jose", "Pepe", "Ana" };

		Funciones.escribirFichero(nombres);
		Funciones.inicializarTabla(nombres);
		Funciones.leerFichero(nombres);
		Funciones.imprimirFichero(nombres);
	}
}