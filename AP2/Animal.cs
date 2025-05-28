public abstract class Animal
{
   public string Nome { get; set; }
    public int Idade { get; set; }
    public double Peso { get; set; }
    public string Especie { get; set; }

    public abstract void EmitirSom();
    public abstract void Movimentar();


    public Animal(string nome, int idade, double peso, string especie)
    {
        this.Nome = nome;
        this.Idade = idade;
        this.Peso = peso;
        this.Especie = especie;
    }
}