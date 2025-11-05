package pe.upn.ejemplografo01.service;

import pe.upn.ejemplografo01.service.Arco;

public class ListaAdyacencia {
	
	private Arco primero;
	private Arco ultimo;

	public ListaAdyacencia() {
		this.primero = null;
		this.ultimo = null;
	}
	
	public boolean listaVacia(){
		return this.primero == null;
	}
	
	
	public void nuevaAdyacencia(Object destino){
		if(!adyacente(destino)){
			Arco nodo = new Arco(destino);
			insertar(nodo,destino);
		}
	}
	
	public void nuevaAdyacencia(Object destino, float peso){
		if(!adyacente(destino)){
			Arco nodo = new Arco(destino, peso);
			insertar(nodo,destino);
		}
	}
	
	private void insertar(Arco nodo, Object destino){
		// Es el primer nodo
		if(this.listaVacia()){
			this.primero = nodo;
			this.ultimo = nodo;
			return;
		}
		// Va al inicio
		if(destino.toString().compareTo(primero.getDestino().toString()) <= 0){
			nodo.setSiguiente(this.primero);
			this.primero = nodo;
			return;
		}
		// Va al ultimo
		if(destino.toString().compareTo(ultimo.getDestino().toString()) >= 0){
			ultimo.setSiguiente(nodo);
			this.ultimo = nodo;
			return;
		}
		// Ubicar su posicion
		Arco posicion = primero;
		while(destino.toString().compareTo(posicion.getDestino().toString())<0){
			posicion = posicion.getSiguiente();
		}
		nodo.setSiguiente(posicion.getSiguiente());
		posicion.setSiguiente(nodo);
	}
	
	public boolean adyacente(Object dato){
		// Variables
		Arco actual;
		boolean encontrado;
		// Proceso
		encontrado = false;
		actual = this.primero;
		while(actual != null && !dato.toString().equals(actual.getDestino().toString())){
			actual =actual.getSiguiente();
		}
		if(actual != null){
			encontrado = true;
		}
		return encontrado;
	}
	
	
}
