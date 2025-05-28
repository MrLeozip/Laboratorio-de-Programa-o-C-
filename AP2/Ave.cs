public class Ave : Animal
{
    public Ave(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} (ave) está cantando");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} (ave) está andando ou nadando.");
    }

    public void Voar()
    {
        Console.WriteLine($"{Nome} (ave) está batendo as asas e voando.");
    }
}