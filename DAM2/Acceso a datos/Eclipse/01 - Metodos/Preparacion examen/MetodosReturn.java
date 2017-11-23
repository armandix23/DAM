
public class MetodosReturn {

	public static int buscarValor(int[] tabla, int valor) { // te dice la posicion del valor seleccionado

		int devolver = -1;
		boolean encontrado = false;

		for (int i = 0; i < 5 &&(!encontrado); i++) {
			if (valor == tabla[i]) {
				devolver = i;
				encontrado = true;
			}
		}
		return devolver;
	}

	static void escribirValores(int[] tabla) { // Imprime toda la tabla
		for(int i=0; i<5; i++) {
			System.out.println(tabla[i]);
			
		}
		return;
	}
	
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		int[] miTabla2 = { 12, 34, 44, 55, 19 };

		int numero = buscarValor(miTabla2, 44);
		System.out.println("La posicion es: " + numero);
		escribirValores(miTabla2);

	}

}
