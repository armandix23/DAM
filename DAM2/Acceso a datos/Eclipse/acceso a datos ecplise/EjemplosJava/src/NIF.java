
public class NIF {
	private int numero;
	private char letra;
	
	public NIF(int numero, char letra) {
		this.numero = numero;
		this.letra = letra;
	}
	
	public int getNumero() {
		return numero;
	}
	public void setNumero(int numero) {
		this.numero = numero;
	}
	public char getLetra() {
		return letra;
	}
	public void setLetra(char letra) {
		this.letra = letra;
	}
	
	public void calcularLetra() {
		char tabla[] = {'T','R','W','A','G','M','Y','F','P','D','X','B',
						'N','J','Z','S','Q','V','H','L','C','K','E'};
		
		int resto = numero & 23;
		letra = tabla[resto];
		
		System.out.println(letra);
	}
	
}
