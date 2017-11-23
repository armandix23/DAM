package Ejercicios;

//import java.util.Scanner;

public class NIF {

	private char letra;
	private int numero;
	
	public NIF(char letra, int numero) {
		
		this.letra = letra;
		this.numero = numero;
	}
	
	public char getLetra() {
		return letra;
	}
	public void setLetra(char letra) {
		this.letra = letra;
	}
	public int getNumero() {
		return numero;
	}
	public void setNumero(int numero) {
		this.numero = numero;
	}
	
	public void calcularLetra() {
		char tabla[] = {'T','R','W','A','G', 
						'M','Y','F','P','D',
						'X','B','N','J','Z',
						'S','Q','V','H','L',
						'C','K','E'};
			
		int resto = numero % 23;
		letra = tabla[resto];
	}
}



	/* String Letras="TRWAGMYFPDXBNJZSQVHLCKE";
    System.out.println("Escribe el DNI sin letra");
    Scanner leer = new Scanner(System.in);
    int dni = Integer.parseInt(leer.next());
    int index = dni - (Math.abs(dni / 23) *23);
    System.out.println("Su letra es:" + Letras.charAt(index));
    System.out.println("Su dni es " +dni+ "-" + Letras.charAt(index));
     */