public class Carro
{
    public string Fabricante;
    public string Modelo;
    public int AnoDeFab;
    public int AnoDeModelo;
    public int Valor;

    public Carro(string fabricante, string modelo, int anoDeFab,int anoDeModelo,int valor)
    {
        Fabricante = fabricante;
        Modelo = modelo;
        AnoDeFab = anoDeFab;
        AnoDeModelo = anoDeModelo;
        Valor = valor;
    }

    public override string ToString()
    {

        return ($"Fabricante:{this.Fabricante}, \nModelo: {this.Modelo}, \nAno de Fabricação: {this.AnoDeFab}, \nAno de Modelo: {this.AnoDeModelo}, \nValor: {this.Valor}\n");
        ;
    }
    
}


