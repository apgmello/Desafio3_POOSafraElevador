namespace Desafio3_POOSafra
{
    internal class Elevador
    {
        private int totalAndares;
        private int capacidade;
        private int quantidadePessoas = 0;
        private int andarAtual = 0;

        public Elevador(int capacidade, int totalAndares)
        {
            if (capacidade <= 0 || totalAndares <= 0)
            {
                throw new ArgumentException("Quantidades devem ser positivas!");
            }
            else
            {
                this.capacidade = capacidade;
                this.totalAndares = totalAndares;
            }
        }
        public void Entrar(int pessoas)
        {
            if ((this.quantidadePessoas + pessoas) <= capacidade)
            {
                this.quantidadePessoas += pessoas;
            }
            else
            {
                throw new ArgumentException("Quantidade de pessoas excede a capacidade do elevador!");
            }
        }

        public void Sair(int pessoas)
        {
            if (pessoas >= 0 && pessoas <= quantidadePessoas)
            {
                this.quantidadePessoas -= pessoas;
            }
            else
            {
                throw new ArgumentException("Não há pessoas para descer!");
            }
        }

        private void Subir(int andares)
        {
            andarAtual += andares;
        }
        private void Descer(int andares)
        {
            andarAtual -= andares;
        }

        public void Deslocar(int andarDestino)
        {
            if(andarDestino > totalAndares || andarDestino < 0)
            {
                throw new ArgumentException("O andar solicitado não existe!");
            }
            
            if(andarDestino == andarAtual)
            {
                throw new ArgumentException("O elevador já se encontra no andar solicitado!");
            }
            
            if(andarDestino < andarAtual)
            {
                Descer(andarAtual - andarDestino);
            }
            else
            {
                Subir(andarDestino - andarAtual);
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"A quantidade atual de pessoas no elevador é: {quantidadePessoas}");
            Console.WriteLine($"O andar atual é: {andarAtual}");
        }
    }

}
