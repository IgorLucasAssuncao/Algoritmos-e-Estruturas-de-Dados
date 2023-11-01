using System;

namespace Lab_10{
    class Cel{
       private Aviao item;
       private Cel? proximo;

       
  public Aviao Item {
    get { return item; }
    set { item = value; }
  }
	public Cel Proximo {
    get { return proximo; }
    set { proximo = value; }
  }
  
	public Cel(Aviao novo) {
		item = novo;
		proximo = null;
	}
	
	public Cel() {
		
		item = new Aviao();
		proximo = null;
	}
    }
}