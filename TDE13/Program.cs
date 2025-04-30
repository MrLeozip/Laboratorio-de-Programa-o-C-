using System.Net.Http.Headers;

Empresa empresa = new Empresa();

Funcionario f1 = new Funcionario("Carlao", 45);
Gerente g1 = new Gerente("Seu Zé", 88, 300000);
Estagiario e1 = new Estagiario("Joao", 19);

empresa.AdicionarFuncionario(f1);
empresa.AdicionarFuncionario(g1);
empresa.AdicionarFuncionario(e1);

empresa.ListarFuncionario();
