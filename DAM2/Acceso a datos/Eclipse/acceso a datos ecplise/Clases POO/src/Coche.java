public class Coche {
	// Atributos
	private int nCaballos;
	private String direccion;
	private int marcha;
	private String matricula;

	// Constructor no devuelven nada
	public Coche() 
	{
		nCaballos = 5;
		direccion = "Parado";
		marcha = 0;
		matricula = "Desconocida";
	}
	
	// Constructor con sobrecarga, quiere decir que tiene parametros
	public Coche(int nCaballos, String direccion, int marcha, String matricula) {
		this.nCaballos = nCaballos;
		this.direccion = direccion;
		this.marcha = marcha;
		this.matricula = matricula;
	}
	
	public void arrancar() 
	{
		direccion = "delate";
		marcha++;
	}
	
	public void girar(String giro) 
	{
		if(giro == "D")
			direccion = "derecha";
		else if(giro == "I")
			direccion = "izquierda";
	}
	
	public void parar() 
	{
		direccion = "Parado";
		marcha = 0;
	}
	
	public String estado()
	{
		return "Caballos:" + nCaballos + " Direccion:" + direccion + " Marcha:" + marcha + " Matricula:" + matricula;
	}
	
	// Generar Getters and Setters necesarios.
	public void setDireccion(String direccion) 
	{
		this.direccion = direccion;
	}
	
	public String getDireccion() 
	{
		return direccion;
	}

	public int getnCaballos() {
		return nCaballos;
	}

	public int getMarcha() {
		return marcha;
	}

	public void setMarcha(int marcha) {
		this.marcha = marcha;
	}
	
	
	
}