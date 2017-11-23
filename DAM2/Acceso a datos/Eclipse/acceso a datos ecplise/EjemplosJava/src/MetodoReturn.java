
public class MetodoReturn {

	public static int buscarValor(int[] tabla, int valor) {
		for (int i = 0; i < 5; i++) {
			if (valor == tabla[i])
				return i;
		}
		return -1;
	}

	public static int buscarValorV2(int[] tabla, int valor) {
		int devolver = -1;
		boolean encontrado = false;
		for (int i = 0; (i < 5) && (!encontrado); i++) {
			if (valor == tabla[i]) {
				devolver = i;
				encontrado = true;
			}
		}
		return devolver;
	}

	public static void escribirValores(int[] tabla) {
		for (int i = 0; i < 5; i++) {
			System.out.println(tabla[i]);
		}
		return; // el return se sale, hace una vez el for y se sale.
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int[] miTabla2 = { 12, 34, 44, 55, 19 };

		int numero = buscarValor(miTabla2, 12);
		System.out.println("La posicion es: " + numero);

		escribirValores(miTabla2);
	}

}
