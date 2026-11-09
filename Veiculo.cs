 public class Veiculo
    {
        private int _velocidade;

        public int Velocidade
        {
            get { return _velocidade; }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    _velocidade = value;
                }
                else
                {
                    Console.WriteLine("Aviso: Valor inválido! A velocidade deve estar entre 0 e 200 km/h. A velocidade não foi alterada.");
                }
            }
        }
    }