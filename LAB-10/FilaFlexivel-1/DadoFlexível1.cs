using System;

namespace Lab_10{
    class Aviao{
        private string voo;
        
		public string Voo {
        get { return voo; }
        set { voo = value; }
    }
  
	public Aviao(string voo) {
		this.voo = voo;
	}

	public Aviao() {
		voo = "";
	}
	
	public void imprimir() {
		Console.WriteLine("voo -> " + voo);
	}
    }
}