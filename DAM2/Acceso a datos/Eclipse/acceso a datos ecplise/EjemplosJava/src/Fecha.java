
public class Fecha {

	private int dia;
	private int mes;
	private int anio;

	// Constructor por defecto
	public Fecha() {
		dia = 1;
		mes = 1;
		anio = 2000;
	}
	
	// Constructor por parametros.
	public Fecha(int d, int m, int a) {
		dia = d;
		mes = m;
		anio = a;
	}
	
	// Getters and Setters
	public int getDia() {
		return dia;
		}
	public void setDia(int d) {
		dia = d;
	}
	public int getMes() {
		return mes;
		}
	public void setMes(int m) {
		mes = m;
	}
	public int getAnio() {
		return anio;
	}
	public void setAnio(int a) {
		anio = a;
	}
	
	public String escribirCorta() {
		return dia + "/" + mes + "/" + anio;
	}
	
	public String escribirLarga() {
		return "Hoy es " + dia + "del mes" + mes + "del anio" + anio;
	}
	
	public boolean correcta() {
		if((dia>=1)&&(dia<=31)&&(mes>=1)&&(mes<=12)&&(anio>=1900))
				return true;
			else
				return false;
	}
}
