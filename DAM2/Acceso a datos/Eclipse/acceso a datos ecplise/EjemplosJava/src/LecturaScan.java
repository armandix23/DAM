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
			// Lectura con m�todos
			int numero0;
			String nombre0;
			
			numero0 = leerNumero();
			nombre0 = leerNombre();
			
			System.out.println("Numero le�do: " + numero0);
			System.out.println("Nombre le�do: " + nombre0);
		}
	}