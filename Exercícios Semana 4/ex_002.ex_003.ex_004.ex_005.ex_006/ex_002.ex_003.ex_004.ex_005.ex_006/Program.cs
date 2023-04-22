using System;
using ex_002.ex_003.ex_004.ex_005.ex_006.Classes;

Cliente cliente00 = new Cliente("Fernando More", DateTime.Parse("1996-05-18"), "Programador", "solteiro", TipoPessoa.FISICA);
ContaBancaria conta00 = new ContaBancaria(1111, 2222, cliente00);

Cliente cliente01 = new Cliente("Pedro João Paulo", DateTime.Parse("1994-11-20"), "Programador", "solteiro", TipoPessoa.FISICA);
ContaPoupanca conta01 = new ContaPoupanca(3333, 4444, cliente01);

Cliente cliente02 = new Cliente("João Antônio", DateTime.Parse("1984-05-25"), "Farmaceutico", "casado", TipoPessoa.FISICA);
ContaCorrente conta02 = new ContaCorrente(5555, 6666, cliente02);

Cliente cliente03 = new Cliente("Encanamentos LTDA", DateTime.Parse("2000-06-04"), "Serviços de encanamento", "", TipoPessoa.JURIDICA);
ContaEmpresarial conta03 = new ContaEmpresarial(5555, 6666, cliente03, 10000, 2, 0, "00.000.000/0001-01");


Console.WriteLine(value: $"Cliente 00: {conta00.Cliente.Nome}");
Console.WriteLine(value: $"Cliente 01: {conta01.Cliente.Nome}");
Console.WriteLine(value: $"Cliente 02: {conta02.Cliente.Nome}");
Console.WriteLine(value: $"Cliente 03: {conta03.Cliente.Nome}  CNPJ: {conta03.CNPJ}");

conta02.Deposito(50);
conta02.Transferencia(40, conta02);