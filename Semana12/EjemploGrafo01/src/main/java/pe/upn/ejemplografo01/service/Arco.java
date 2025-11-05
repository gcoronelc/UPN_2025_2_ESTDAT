package pe.upn.ejemplografo01.service;

public class Arco {

	private Object destino;
	private double peso;
	private Arco siguiente;

	public Arco(Object dato) {
		this.destino = dato;
		this.peso = 1;
		this.siguiente = null;
	}

	public Arco(Object dato, double peso) {
		this.destino = dato;
		this.peso = peso;
		this.siguiente = null;
	}

	public Object getDestino() {
		return destino;
	}

	public void setDestino(Object destino) {
		this.destino = destino;
	}

	public double getPeso() {
		return peso;
	}

	public void setPeso(double peso) {
		this.peso = peso;
	}

	public Arco getSiguiente() {
		return siguiente;
	}

	public void setSiguiente(Arco siguiente) {
		this.siguiente = siguiente;
	}

}
