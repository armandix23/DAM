package FicherosEJER;

import java.util.Scanner;

public class LecturaScan {

	public static int leerNumero()

	{

		Scanner scan = new Scanner(System.in);

		System.out.println("Introduce numero: ");

		return scan.nextInt();

	}

	public static String leerNombre()

	{

		Scanner scan = new Scanner(System.in);

		System.out.println("Introduce nombre: ");

		return scan.nextLine();

	}

	public static void main(String[] args)

	{

		// 0. Lectura con métodos

		int numero0;

		String nombre0;

		numero0 = leerNumero();

		nombre0 = leerNombre();

		System.out.println("Numero leído: " + numero0);

		System.out.println("Nombre leído: " + nombre0);

		// 1. Lectura con Scanner sin reset sobre mismo scan

		Scanner scan1 = new Scanner(System.in);

		int numero1;

		String nombre1;

		System.out.println("Introduce numero: ");

		numero1 = scan1.nextInt(); // Lectura de número entero

		System.out.println("Introduce nombre: ");

		nombre1 = scan1.nextLine(); // Lectura de nombre como String incluyendo \n

		System.out.println("Numero leído: " + numero1);

		System.out.println("Nombre leído: " + nombre1);

		// 2. Lectura con Scanner eliminado intro con nextLine sobre mismo scan

		Scanner scan2 = new Scanner(System.in);

		int numero2;

		String nombre2;

		System.out.println("Introduce numero: ");

		numero2 = scan2.nextInt(); // Lectura de número entero

		scan2.nextLine(); // Lectura de \n tras el número entero

		System.out.println("Introduce nombre: ");

		nombre2 = scan2.nextLine(); // Lectura del nombre como String

		System.out.println("Numero leído: " + numero2);

		System.out.println("Nombre leído: " + nombre2);

		// 3. Lectura con Scanner con reset sobre distinto scan

		Scanner scan3,

				scan4;

		int numero3;

		String nombre3;

		scan3 = new Scanner(System.in);

		System.out.println("Introduce numero: ");

		numero3 = scan3.nextInt(); // Lectura de número entero (\n se queda en scan3)

		scan4 = new Scanner(System.in);

		System.out.println("Introduce nombre: ");

		nombre3 = scan4.nextLine(); // Lectura de nombre como String

		System.out.println("Numero leído: " + numero3);

		System.out.println("Nombre leído: " + nombre3);

	}

}
