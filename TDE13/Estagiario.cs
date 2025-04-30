public class Estagiario : Funcionario
{
    public Estagiario(string nome, int idade) : base(nome, idade)
    {

    }

    public override double CalcularSalario()
    {
        return base.CalcularSalario() / 2;
    }
}