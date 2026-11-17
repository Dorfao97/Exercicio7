ContaBancaria conta = new();

Console.WriteLine("Informe o nome do titular da conta:");
string nome = Console.ReadLine();
conta.setTitular(nome);

Console.WriteLine("\nDigite o valor para depósito:");
double valorDeposito = double.Parse(Console.ReadLine());
Console.WriteLine();
conta.Depositar(valorDeposito);

Console.WriteLine("\nDigite o valor para saque:");
double valorSaque = double.Parse(Console.ReadLine());
Console.WriteLine();
conta.Sacar(valorSaque);

Console.WriteLine("\nExibindo Saldo");
conta.ExibirSaldo();

