// See https://aka.ms/new-console-template for more information

        var pacientes = new List<(string Tipo, string Nome, int Idade, string Sintoma)>();
        string continuar = "s";

        Console.WriteLine("=== Sistema de Cadastro Hospitalar ===");

        while (continuar.ToLower() == "s")
        {
            Console.Write("\nTipo (Paciente/Médico/Enfermeiro): ");
            string tipo = Console.ReadLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Sintoma: ");
            string sintoma = Console.ReadLine();

            pacientes.Add((tipo, nome, idade, sintoma));
            Console.WriteLine("Cadastro realizado com sucesso!");

            Console.Write("\nDeseja cadastrar outra pessoa? (s/n): ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("\n=== Lista de Cadastros ===");
        foreach (var p in pacientes)
        {
            Console.WriteLine($"{p.Tipo} {p.Nome}, {p.Idade} anos, está com {p.Sintoma}.");
        }

        Console.WriteLine("\nSistema encerrado. Obrigado!");
