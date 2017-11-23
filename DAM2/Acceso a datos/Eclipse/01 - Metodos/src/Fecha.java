public class Fecha {

	private int dia, mes, anio;

	public Fecha() {
		
		dia=1;
		mes=1;
		anio=2017;
	}
	
	
	public void setDia(int d) {
		dia = d;
	}

	public void setMes(int m) {
		mes = m;
	}


	public void setAnio(int a) {
		anio = a;
	}


	public String escribeCorto() {
		
		return dia + "/" + mes + "/" + anio;
		
	}
	
	
	
	



}