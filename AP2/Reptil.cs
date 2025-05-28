public class Reptil : Animal
{
    public Reptil(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} (réptil) está sibilando ou fazendo ruídos específicos.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} (réptil) está andando.");
    }

    public void Rastejar()
    {
        Console.WriteLine($"{Nome} (réptil) está se arrastando pelo chão.");
    }
}