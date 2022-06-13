using Desafio3_POOSafra;

int capacidade;
int totalAndares;
int andarDestino;
int quantidadeDePessoas;
int sair;

try
{
    Console.Write("Qual a capacidade de pessoas do elevador: ");
    int.TryParse(Console.ReadLine(), out capacidade);
    Console.Write("Qual o total de andares do prédio: ");
    int.TryParse(Console.ReadLine(), out totalAndares);

    Elevador elevador = new Elevador(capacidade, totalAndares);

    do
    {
        Console.Write("Informe a quantidade de pessoas que vão entrar no elevador: ");
        int.TryParse(Console.ReadLine(), out quantidadeDePessoas);
        elevador.Entrar(quantidadeDePessoas);

        Console.Write("Qual o andar de destino: ");
        int.TryParse(Console.ReadLine(), out andarDestino);
        elevador.Deslocar(andarDestino);

        Console.Write("Quantas pessoas vão descer: ");
        int.TryParse(Console.ReadLine(), out sair);
        elevador.Sair(sair);
        Console.Clear();
        elevador.Imprimir();

    } while (true);
}
catch(ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}