// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");

Pessoa p = new Pessoa();

p.Nome = "Gomes";
p.Sobrenome = "Oliveira";
p.CPF = 12345678;

Console.WriteLine($"Ola {p.Nome} {p.Sobrenome} seu CPF é {p.CPF}"); */
Console.WriteLine ("Digite seu nome: ");
string? nome = Console.ReadLine();

Console.WriteLine ("Digite seu sobrenome: ");
string? sobrenome = Console.ReadLine();

Console.WriteLine ("Digite a sua data de nascimento no formato dd/mm/yy: ");
DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);

Console.WriteLine ("Digite seu CPF sem ponto ou caracter:");
int.TryParse(Console.ReadLine(), out int cpf);

Console.WriteLine("Digite seu peso: ");
decimal.TryParse(Console.ReadLine(), out decimal peso);

Console.WriteLine("Digite sua altura: ");
decimal.TryParse(Console.ReadLine(), out decimal altura);

Pessoa p = new Pessoa (nome, sobrenome, dataNascimento, cpf, peso, altura);

int Idade = p.CalculaIdade();

decimal imc = Math.Round(p.CalculaIMC(),2);

bool sair = false;

while(!sair)
{
    Console.WriteLine("Escolha uma das opções abaixo!");
    Console.WriteLine("0 - Informações dos usuários");
    Console.WriteLine("1 - Calcular IMC");
    Console.WriteLine("2 - Verificar a maioridade do usuário");
    Console.WriteLine("3 - Calculadora");
    Console.WriteLine("4 - Calculadora de IMC");
    Console.WriteLine("5 - Sair");

    string? opcao = Console.ReadLine();

switch(opcao)
{
    case "0":
    Console.WriteLine($"Nome Completo: {nome} {sobrenome}");
    Console.WriteLine($"Data de Nascimento: {dataNascimento}");
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"CPF: {cpf}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Idade: {Idade}");
    break;

case "1":
Console.WriteLine($"Seu IMC é: {imc}"); 
if(imc < 17)
{
    Console.WriteLine ($"Ola {nome}, você foi classificado como Muito Abaixo do Peso, por ter {imc} de IMC!");
}else if(imc >=17 && imc < 19)
{
    Console.WriteLine ($"Ola {nome}, você foi classificado como Abaixo do Peso, por ter {imc} de IMC!");
}else if(imc >=19 && imc < 25)
{
    Console.WriteLine ($"Ola {nome}, você foi classificado como Peso normal, por ter {imc} de IMC!");
}else if(imc >=25 && imc < 30)
{
    Console.WriteLine ($"Ola {nome}, você foi classificado como Obesidade grau I, por ter {imc} de IMC!");
}else if(imc >=30 && imc < 35)
{
    Console.WriteLine ($"Ola {nome}, você foi classificado como Obesidade grau II, por ter {imc} de IMC!");
}else if(imc >=35 && imc < 40)
{
    Console.WriteLine ($"Ola {nome}, você foi classificado como Obesidade grau III, por ter {imc} de IMC!");
}else if(imc > 40)


break;


    break;

    case "2":
    if(Idade >= 18)
    {
        Console.WriteLine($"Ola {nome}, parabens voce ja e maior de idade por ter {Idade} de idade");
    }else
    Console.WriteLine($"Ola {nome}, voce e menor de idade por ter {Idade} de idade");
    break;

    case "3":

            Calcular c = new Calcular();

            Console.WriteLine("Digite o Primeiro valor");
            c.Numero1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Primeiro valor");
            c.Numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escolha uma das operação");
            Console.WriteLine("a. Adição (+)");
            Console.WriteLine("b. Subtração (-)");
            Console.WriteLine("c. Multiplicação (*)");
            Console.WriteLine("d. Divisão (/)");

            string? operacao = Console.ReadLine();
            float resultado = 0;
            switch (operacao)
            {
                case "a":
                resultado = c.Soma();
                break;

                case "b":
                resultado = c.Subtracao();
                break;

                case "c":
                resultado = c.Multiplicacao();
                break;

                case "d":
                resultado = c.Divisao();
                break;

                default:
                Console.WriteLine("Operação inválida");
                break;
            }
            Console.WriteLine($"Resultado {resultado}");
            break;

            default:
            Console.WriteLine($"Opção inválida");
            break;

    case "4"
    Console.WriteLine("Digite seu peso aqui!");
    decimal.TryParse(Console.ReadLine(), out decimal cPeso);
    Console.WriteLine("Digite sua altura aqui!");
    decimal.TryParse(Console.ReadLine(), out decimal cAltura);


    break;

    case "5":
    sair = true;
    break;

}

}


    




