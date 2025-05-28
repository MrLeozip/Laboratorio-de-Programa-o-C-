public class Mamifero : Animal
{
    public Mamifero(string nome, int idade, double peso, string especie)
        : base(nome, idade, peso, especie)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine($"{Nome} (mamífero) está emitindo um som característico.");
    }

    public override void Movimentar()
    {
        Console.WriteLine($"{Nome} (mamífero) está se movimentando no chão ou nadando.");
    }

    public void Amamentar()
    {
        Console.WriteLine($"{Nome} (mamífero) está amamentando seus filhotes.");
    }
}