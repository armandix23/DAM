package actividad3;

/* Crear una clase para gestionar Productos de una tienda de informatica, que se define
por nombre y precio. Tendra que contener las siguientes operaciones: rebajar el precio, 
aumentar el precio. Completar con:

	- Programa principal que cree 4 Productos, lea el contenido de los productos de un  fichero
	  de texto, aumente 10% el precio del 1 producto, disminuya un 20% el precio del 2 producto
	  y escriba por pantalla los datos de los 4 productos.
*/

public class Productos {

	private String nombre;
	private double precio;

	public Productos() {
		nombre = "";
		precio = 0;
	}

	// Metodos
	
	public void aumentar(double p) 
	{
		precio = precio + ((p/100)*precio);
	}
	
	public void disminuir(double p) 
	{
		precio = precio - ((p/100)*precio);
	}
	
	public String imprimir() 
	{
		return "Nombre: " + nombre + " Precio: " + precio;
	}

	// Setters

	public void setNombre(String n) {
		nombre = n;
	}

	public void setPrecio(int p) {
		precio = p;
	}

}
