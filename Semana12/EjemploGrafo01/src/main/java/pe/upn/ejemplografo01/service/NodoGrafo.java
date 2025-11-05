package pe.upn.ejemplografo01.service;

public class NodoGrafo {

	private Object dato;
	private ListaAdyacencia lista;
	private NodoGrafo siguiente;

	public NodoGrafo(Object dato) {
		this.dato = dato;
		this.lista = new ListaAdyacencia();
		this.siguiente = null;
	}

	public Object getDato() {
		return dato;
	}

	public void setDato(Object dato) {
		this.dato = dato;
	}

	public ListaAdyacencia getLista() {
		return lista;
	}

	public void setLista(ListaAdyacencia lista) {
		this.lista = lista;
	}

	public NodoGrafo getSiguiente() {
		return siguiente;
	}

	public void setSiguiente(NodoGrafo siguiente) {
		this.siguiente = siguiente;
	}

	
	
}
