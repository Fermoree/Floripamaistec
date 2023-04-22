using M1S02.DadosBancarios;
using M1S02.DadosBancarios.Enum;

ContaBancaria conta = new ContaBancaria();
conta.numero = 1805;
conta.agencia = 0301;
conta.nomeDoTitular = "Fernando da Cunha Ocampo More";
conta.tipoConta = TipoContaEnum.POUPANCA;

// testando método depositar
conta.Depositar(100);

// testando método sacar 
conta.Sacar(20);

// testando método exibir saldo
conta.ExibirSaldo();
