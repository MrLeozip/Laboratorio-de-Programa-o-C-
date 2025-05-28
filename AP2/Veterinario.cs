public class Veterinario : Funcionario, ITratamentoAnimal
{
    public Veterinario(string nome, int idade) : base(nome, idade, "Veterinário") { }

    public override void Trabalhar()
    {
        Console.WriteLine($"{Nome} está realizando seu trabalho de {Cargo}.");
    }

    public void ConsultarAnimal(Animal animal)
    {
        Console.WriteLine($"Veterinário {Nome} consultou o animal {animal.Nome} com sucesso.");
    }

    public void RealizarTratamento(Animal animal)
    {
        Console.WriteLine($"Veterinário {Nome} realizou tratamento no animal {animal.Nome}.");
    }
}
