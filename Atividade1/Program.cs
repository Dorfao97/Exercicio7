using System.Net.WebSockets;

Carro CadastrarCarro()
{
    Console.WriteLine("Informe o Fabricante: ");
    string fab = Console.ReadLine();
    Console.WriteLine("Informe o Modelo: ");
    string mod = Console.ReadLine();
    Console.WriteLine("Informe o Ano de Fabricacao: ");
    int anofab = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Ano do Modelo: ");
    int anomod = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o Valor de Venda: ");
    double preco = double.Parse(Console.ReadLine());

    Console.WriteLine("Informe o Combustível (G - Gasolina, A - Álcool, F - Flex, D - Diesel): ");
    char comb = char.Parse(Console.ReadLine());
    Console.WriteLine("Informe a Cilindrada: ");
    int cil = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe a Potência: ");
    int pot = int.Parse(Console.ReadLine());

    Motor m = new Motor();
    m.setCombustivel(comb);
    m.setCilindrada(cil);
    m.setPotencia(pot);

    Carro c = new Carro();
    c.setFabricante(fab);
    c.setModelo(mod);
    c.setAnoFabricacao(anofab);
    c.setAnoModelo(anomod);
    c.setValorVenda(preco);
    c.setMotor(m);

    return c;
}


Carro[] carros = new Carro[4];

for (int i = 0; i < carros.Length; i++)
{
    carros[i] = CadastrarCarro();
    Console.WriteLine();
}

void MostrarCarros()
{
    for (int i = 0; i < carros.Length; i++)
    {
        Console.WriteLine(carros[i]);
        Console.WriteLine();
    }
}

void CalcularIPVA()
{
    int anoAtual = DateTime.Now.Year;
    double valorIPVA = 0;

    for (int i = 0; i < carros.Length; i++)
    {
        int idadeCarro = anoAtual - carros[i].getAnoFabricacao();

        if (idadeCarro > 20)
        {
            Console.WriteLine($"Modelo {carros[i].getModelo()}: Isento de IPVA (mais de 20 anos).");
        }
        else
        {
            valorIPVA = carros[i].getValorVenda() * 0.04;
            Console.WriteLine($"IPVA do {carros[i].getModelo()}: R$ {valorIPVA:F2}");
        }
    }
}

MostrarCarros();
Console.WriteLine();
CalcularIPVA();