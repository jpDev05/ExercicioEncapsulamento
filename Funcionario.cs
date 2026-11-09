 public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; private set; } // Leitura pública, escrita privada

        public Funcionario(string nome, string cargo, double salarioInicial)
        {
            Nome = nome;
            Cargo = cargo;
            Salario = salarioInicial;
        }

        public void AumentarSalario(double percentual)
        {
            Salario += Salario * (percentual / 100);
        }

        public void ConsultarSalario()
        {
            Console.WriteLine($"Salário atual de {Nome}: R$ {Salario:F2}");
        }
    }