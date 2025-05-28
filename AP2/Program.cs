class Program
    {
        static List<Animal> animais = new List<Animal>();
        static List<Funcionario> funcionarios = new List<Funcionario>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Sistema de Gerenciamento do Zoológico ===");
                Console.WriteLine("1. Cadastrar Animal");
                Console.WriteLine("2. Cadastrar Funcionário");
                Console.WriteLine("3. Interação Animal-Funcionário");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarAnimal();
                        break;
                    case "2":
                        CadastrarFuncionario();
                        break;
                    case "3":
                        InteracaoAnimalFuncionario();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void CadastrarAnimal()
        {
            Console.WriteLine("\n=== Cadastro de Animal ===");
            Console.WriteLine("1. Mamífero");
            Console.WriteLine("2. Ave");
            Console.WriteLine("3. Réptil");
            Console.Write("Escolha o tipo de animal: ");
            string tipo = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Peso (kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Espécie: ");
            string especie = Console.ReadLine();

            Animal animal = tipo switch
            {
                "1" => new Mamifero(nome, idade, peso, especie),
                "2" => new Ave(nome, idade, peso, especie),
                "3" => new Reptil(nome, idade, peso, especie),
                _ => null
            };

            if (animal != null)
            {
                animais.Add(animal);
                Console.WriteLine($"Animal cadastrado com sucesso: Nome: {animal.Nome}, Idade: {animal.Idade}, Peso: {animal.Peso}kg, Espécie: {animal.Especie}");
            }
            else
            {
                Console.WriteLine("Tipo inválido.");
            }
        }

        static void CadastrarFuncionario()
        {
            Console.WriteLine("\n=== Cadastro de Funcionário ===");
            Console.WriteLine("1. Veterinário");
            Console.WriteLine("2. Zelador");
            Console.Write("Escolha o tipo de funcionário: ");
            string tipo = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Funcionario funcionario = tipo switch
            {
                "1" => new Veterinario(nome, idade),
                "2" => new Zelador(nome, idade),
 
                _ => null
            };

            if (funcionario != null)
            {
                funcionarios.Add(funcionario);
                Console.WriteLine($"Funcionário cadastrado com sucesso: Nome: {funcionario.Nome}, Idade: {funcionario.Idade}, Cargo: {funcionario.Cargo}");
            }
            else
            {
                Console.WriteLine("Tipo inválido.");
            }
        }

        static void InteracaoAnimalFuncionario()
        {
            if (animais.Count == 0 || funcionarios.Count == 0)
            {
                Console.WriteLine("É necessário cadastrar ao menos um animal e um funcionário.");
                return;
            }

            Console.WriteLine("\n=== Lista de Animais ===");
            for (int i = 0; i < animais.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {animais[i].Nome} ({animais[i].Especie})");
            }
            Console.Write("Escolha um animal: ");
            int idxAnimal = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("\n=== Lista de Funcionários ===");
            for (int i = 0; i < funcionarios.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {funcionarios[i].Nome} ({funcionarios[i].Cargo})");
            }
            Console.Write("Escolha um funcionário: ");
            int idxFuncionario = int.Parse(Console.ReadLine()) - 1;

            Animal animal = animais[idxAnimal];
            Funcionario funcionario = funcionarios[idxFuncionario];

            Console.WriteLine();
            if (funcionario is Veterinario vet)
            {
                vet.ConsultarAnimal(animal);
                vet.RealizarTratamento(animal);
            }
            else if (funcionario is Zelador zelador)
            {
                zelador.AlimentarAnimal(animal);
                zelador.CuidarHabitat(animal);
            }
        }
    }