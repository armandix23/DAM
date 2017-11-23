package Ejercicios;

public class FechaE{

	private int dia,mes,anio;

	public FechaE(){
	
		dia=1;
		mes=1;
		anio=2017;
	}

	public 	FechaE(int d, int m, int a) {
		dia = d;
		mes = m;
		anio = a;
		
	}
	
	/*public FechaE(int dia, int mes, int anio) { OTRA OPCION DE CONSTRUCTOR
	
	this.dia = dia;
	this.mes = mes;
	this.anio = anio;
}*/

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

	public String escribeCorta() {
		return dia + "/" + mes + "/" + anio;
	}
	
	public String escribeLarga() {
		return "Hoy es"+ dia + "del mes " + mes + "del año" + anio;
	}
	
	public boolean correcta() {
		if( (dia>1) && (dia<=31) && (mes>1) && (mes<=12) && (anio>=1900))
			return true;
		else
			return false;
			
	}
	
	
	
	


}
