using System;

namespace Lab8{
     class Pilha {

	private Celula fundo;
	private Celula topo;
	
	public Pilha() {
		Celula sentinela;
		sentinela = new Celula();
		fundo = sentinela;
		topo = sentinela;
	}
	
	public Boolean pilhaVazia() {
	
		Boolean resp;
		
		if (topo == fundo)
			resp = true;
		else
			resp = false;
		
		return resp;
	}
	
	public void empilhar(Item novo) {
		
		Celula novaCelula;
		
		novaCelula = new Celula(novo);
		novaCelula.Proximo = topo;
		topo = novaCelula;
	}
	
	public Item desempilhar() {
		
		Celula desempilhado;
		
		if (! pilhaVazia()) {
			desempilhado = topo;
			topo = topo.Proximo;
			desempilhado.Proximo = null;
			return (desempilhado.Entrada);
		} else
			 throw new Exception("Não foi possível desempilhar: a pilha está vazia!");
	}
	
	public Item consultarTopo() {
		
		if (! pilhaVazia()) {
			return topo.Entrada;
		} else
			 throw new Exception("Não foi possível consultar o topo da pilha: a pilha está vazia!");
	}
}
}