using ExercicioEncapsulamento;
    bool continuar = true;

    while (continuar)
    {
        Console.WriteLine("\n=================================");
        Console.WriteLine(" ESCOLHA O EXERCÍCIO PARA RODAR ");
        Console.WriteLine("=================================");
        Console.WriteLine("1 - Apresentação de pessoas");
        Console.WriteLine("2 - Métodos de instância e estáticos");
        Console.WriteLine("3 - Propriedades com validação");
        Console.WriteLine("4 - Propriedades e controle de acesso");
        Console.WriteLine("5 - Construtores e sobrecarga");
        Console.WriteLine("0 - Sair");
        Console.Write("Opção: ");
        
        string opcao = Console.ReadLine();
        Console.WriteLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("=== EXERCÍCIO 1 ===");
                Pessoa pessoa1 = new Pessoa { Nome = "Ana", Idade = 28, Cidade = "São Paulo" };
                Pessoa pessoa2 = new Pessoa { Nome = "Carlos", Idade = 35, Cidade = "Rio de Janeiro" };
                pessoa1.Apresentar();
                pessoa2.Apresentar();
                break;

            case "2":
                Console.WriteLine("=== EXERCÍCIO 2 ===");
                Calculadora calc = new Calculadora();
                Console.WriteLine($"Soma (instância): {calc.Somar(10, 5)}");
                Console.WriteLine($"Subtração (instância): {calc.Subtrair(10, 5)}");
                Console.WriteLine($"Multiplicação (instância): {calc.Multiplicar(10, 5)}");
                Console.WriteLine($"Divisão (estático): {Calculadora.Dividir(10, 5)}");
                break;

            case "3":
                Console.WriteLine("=== EXERCÍCIO 3 ===");
                Veiculo carro = new Veiculo();
                carro.Velocidade = 100;
                Console.WriteLine($"Tentativa 100 km/h -> Velocidade atual: {carro.Velocidade} km/h");
                carro.Velocidade = 250; // Inválido
                Console.WriteLine($"Tentativa 250 km/h -> Velocidade atual: {carro.Velocidade} km/h");
                carro.Velocidade = -10; // Inválido
                Console.WriteLine($"Tentativa -10 km/h -> Velocidade atual: {carro.Velocidade} km/h");
                break;

            case "4":
                Console.WriteLine("=== EXERCÍCIO 4 ===");
                Funcionario func = new Funcionario("João", "Desenvolvedor", 5000);
                func.ConsultarSalario();
                func.AumentarSalario(10);
                Console.WriteLine("Após aumento de 10%:");
                func.ConsultarSalario();
                // A linha abaixo daria erro de compilação (leitura pública, escrita privada):
                // func.Salario = 10000; 
                break;

            case "5":
                Console.WriteLine("=== EXERCÍCIO 5 ===");
                Livro livro1 = new Livro();
                Livro livro2 = new Livro("O Senhor dos Anéis");
                Livro livro3 = new Livro("1984", "George Orwell");
                Livro livro4 = new Livro("Dom Casmurro", "Machado de Assis", 256);
                livro1.ExibirDados();
                livro2.ExibirDados();
                livro3.ExibirDados();
                livro4.ExibirDados();
                break;

            case "0":
                continuar = false;
                break;

            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}