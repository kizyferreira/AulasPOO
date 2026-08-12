Carro c1 = new Carro();

/*Console.WriteLine("Informe a placa do carro: ");
c1.placa = Console.ReadLine();

Console.WriteLine("Informe o modelo do carro: ");
c1.modelo = Console.ReadLine();

Console.WriteLine("Informe a marca do carro: ");
c1.marca = Console.ReadLine();

Console.WriteLine("Informe a cor do carro: ");
c1.cor = Console.ReadLine();


Console.WriteLine($"Esses são os dados do carro cadastrado: Placa: {c1.placa} Modelo: {c1.modelo} Marca: {c1.marca} Cor: {c1.cor}");*/

Aluguel a1 = new Aluguel(2,"A2");

//Console.WriteLine("Informe a data do aluguel: ");
//a1.data = Convert.ToDateTime(Console.ReadLine());

Console.WriteLine("Informe a quantidade de horas: ");
a1.totalHoras = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Informe o valor da hora: ");
//a1.valorHora = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Informe o número da vaga: ");
//a1.numVaga = Console.ReadLine();

a1.CalcularValor();/*

/*double valorCalculado = a1.CalcularValorComRetorno(10);
if (valorCalculado > 100)
    Console.WriteLine("Valor x");
else
    Console.WriteLine("Valor ok");
Console.WriteLine($"Valor total: {valorCalculado} ");*/


/////instanciando um novo proprietario

Proprietario p1 = new Proprietario();

Console.Write("Digite o nome do proprietário: ");
p1.Nome = Console.ReadLine();

Console.Write("Digite o CPF do proprietário: ");
p1.Cpf = Console.ReadLine();

bool ehValido = p1.ValidarCpf();

if (ehValido)
{
    Console.WriteLine($"CPF do proprietário {p1.Nome} é VÁLIDO!");
}
else
{
    Console.WriteLine($"CPF do proprietário {p1.Nome} é INVÁLIDO!");
}









