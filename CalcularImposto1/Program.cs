
using CalcularImposto1.classes;

PessoaFisica novaPf = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPf.nome = "samuel";

novaPf.cpf = "222222220";

novaPf.rendimento = 1500;

novaPf.dataNasc = new DateTime (2000, 01, 01);

novoEndPf.logadouro = "Rua niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "senai";
novoEndPf.andComercial = true;

novaPf.endereco = novoEndPf;
Console.WriteLine($@"

        nome:{novaPf.nome}
        endereco:{novaPf.endereco.logadouro}, {novaPf.endereco.numero}
        maior de idade?:{novaPf.ValidarDataNacimento(novaPf.dataNasc)}

");

// calcular imposto pessoa Fizica

//float ImpostoPagar = novaPf.CalcularImposto(novaPf.rendimento);

//Console.WriteLine($"Nome:{novaPf.nome} - CPF:{novaPf.cpf} resultado {ImpostoPagar}");

// calcular imposto pessoa Juridica

//PessoaJuridica novaPj = new PessoaJuridica( );

//Console.WriteLine(novaPj.CalcularImposto(1500));


