// Exercício 1 

int dia;

Console.WriteLine("Escolha um número de um a sete");
dia = int.Parse(Console.ReadLine());
switch (dia)
{
    case 1:
        Console.WriteLine("Domingo");
        break;

        case 2:
        Console.WriteLine("Segunda-Feira");

        break;

        case 3:
        Console.WriteLine("Terça-Feira");
        break;

        case 4:
        Console.WriteLine("Quart-Feira");
        break;

        case 5:
        Console.WriteLine("Quinta-Feira");
        break;

        case 6:
        Console.WriteLine("Sexta-Feira");
        break;

        case 7:
        Console.WriteLine("Sábado");
        break;
}


//Exercício 2

float vc, met, desc, acres;

Console.WriteLine("Digite o valor de compra");
vc = float.Parse(Console.ReadLine());
Console.WriteLine("Qual o método deseja aplicar");
Console.WriteLine("1- Dinheiro 2- Pix 3- Débito 4- Crédito");
met = float.Parse(Console.ReadLine());
switch (met)
{
    case 1:
        desc=((vc * 0.15f) - vc);
        Console.WriteLine("O total a ser pago é de {0}", desc);
        break;

        case 2:
        desc = ((vc * 0.10f) - vc);
        Console.WriteLine("O total a ser pago é de {0}", desc);
        break;

        case 3:
        acres = ((vc * 0.5f) + vc);
        Console.WriteLine("O total a ser pago é de {0}", acres);
        break;

    case 4:
        acres = ((vc * 0.10f) + vc);
        Console.WriteLine("o total a ser pago é de {0}", acres);
        break;

   default:
        Console.WriteLine("Não há essa opção");
        break;

}


// Exercício 3

int mes, fev;
Console.WriteLine("Olá, bem vindo!");
Console.WriteLine("1- Janeiro 2- Fevereiro 3- Março 4- Abril 5- Maio 6- Junho 7- Julho 8- Agosto 9- Setembro 10- Outubro 11- Novembro      12- Dezembro");
mes = int.Parse(Console.ReadLine());
switch (mes)
{

    case 1:
        Console.WriteLine("Janeiro, trinta e um dias");
        break;

    case 2:
        Console.WriteLine("Insira o ano em que estamos");
        fev = int.Parse(Console.ReadLine());    
        if(fev % 4== 0)
        {
            Console.WriteLine("Fevereiro, vinte e nove dias");
                
                }
        else
        {
            Console.WriteLine("Fevereiro, vinte e oito dias");
        }
        break;

    case 3:
        Console.WriteLine("Março, trinta e um dias");
        break;

    case 4:
        Console.WriteLine("Abril, trinta dias");
        break;
   
    case 5:
        Console.WriteLine("Maio, trinta e um dias");
        break;

    case 6:
        Console.WriteLine("Junho, trinta dias");
        break;

    case 7:
        Console.WriteLine("Julho, trinta e um dias");
        break;

    case 8:
        Console.WriteLine("Agosto, trinta dias");
        break;

    case 9:
        Console.WriteLine("Setembro, trinta e um dias");
        break;

    case 10:
        Console.WriteLine("Outubro, trinta dias");
        break;

    case 11:
        Console.WriteLine("Novembro, trinta e um dias");
        break;
       
    case 12:
        Console.WriteLine("Dezembro, trinta dias");
        break;
}


// Exercício 4

int n1, n2, oper, res;

Console.WriteLine("Bem vindo a calculadora 2.0");
Console.WriteLine("1 - Adição 2- Subtração 3- Multiplicação 4- Divisão 5- Exponencial");
oper = int.Parse(Console.ReadLine());
switch (oper)
{
    case 1:
        Console.WriteLine("Dê o primeiro valor");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dê o segundo valor ");
        n2 = int.Parse(Console.ReadLine());
        res = (n1 + n2);
        Console.WriteLine("o reslutado da operação solicitada é {0}", res);
        break;

    case 2:
        Console.WriteLine("Dê o primeiro valor");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dê o segundo valor ");
        n2 = int.Parse(Console.ReadLine());
        res = (n1 - n2);
        Console.WriteLine("o reslutado da operação solicitada é {0}", res);
        break;

    case 3:

        Console.WriteLine("Dê o primeiro valor");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dê o segundo valor ");
        n2 = int.Parse(Console.ReadLine());
        res = (n1 * n2);
        Console.WriteLine("o reslutado da operação solicitada é {0}", res);
        break;

    case 4:
        Console.WriteLine("Dê o primeiro valor");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dê o segundo valor ");
        n2 = int.Parse(Console.ReadLine());
        res = (n1 / n2);
        Console.WriteLine("o reslutado da operação solicitada é {0}", res);
        break;

    case 5:
        Console.WriteLine("Dê o primeiro valor");
        n1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Dê o segundo valor ");
        n2 = int.Parse(Console.ReadLine());
        res = (n1 ^ n2);
        Console.WriteLine("o reslutado da operação solicitada é {0}", res);
        break;

    default:
        Console.WriteLine("Opção invalida");
        break;
}


//Exercício 5
float sal, carg, tot8;

Console.WriteLine("Deseja ver seu novo salário?");
Console.WriteLine("Primeiro insire seu salário");
sal = float.Parse(Console.ReadLine());
Console.WriteLine("Selecione seu cargo na empresa por meio do código");
Console.WriteLine("101- Professor 102- Secretário 103- Publicitário 204- Jornalista 206- Mecânico 301- Estagiario 302- Técnico de TI");
carg = float.Parse(Console.ReadLine());

switch (carg)
{
    case 101:
        tot8 = ((sal * 0.075f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;


    case 102:
        tot8 = ((sal * 0.097f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;

    case 103:
        tot8 = ((sal * 0.117f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;

    case 204:
        tot8 = ((sal * 0.089f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;

    case 206:
        tot8 = ((sal * 0.1324f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;

    case 301:
        tot8 = ((sal * 0.104f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;
   
    case 302:
        tot8 = ((sal * 0.146f) + sal);
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;

        default:
        tot8 = ((sal * 0.435f));
        Console.WriteLine("Você passou a receber {0}", tot8);
        Console.WriteLine("Você recebia o total de {0}", sal);
        break;
}



//Exercício 6

float imp, sm, sl;

Console.WriteLine("Escolha a faixa de renda para efetuarmos o calculo do imposto de renda");
Console.WriteLine("1- até 1903,98 2- R$ 1903,99 á R$ 2826,65 3- R$2826,66 á R$3751,05 4- R$3751,06 á 4664,68 5- Acima de R$ 4664,69");
imp = int.Parse(Console.ReadLine());

switch (imp)
{
    case 1:
        Console.WriteLine("Digite quantos você recebe mensalmente");
        sm = float.Parse(Console.ReadLine());
        if (sm > 1903.98f)
        {
            Console.WriteLine("Seu valor ultrapassa o valor total dessa faixa");
        }
        else
        {
            Console.WriteLine("Isento á imposto de renda");
            Console.WriteLine("Seu salário liquído é de {0}", sm);
        }
        break;

    case 2:
        Console.WriteLine("Digite quantos você recebe mensalmente");
        sm = float.Parse(Console.ReadLine());
        if (sm < 1903.99f || sm > 2826.65f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
        }
        else
        {
            sl = (sm -(sm * 0.075f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);

        }
        break;

    case 3:
        Console.WriteLine("Digite quantos você recebe mensalmente ");
        sm = float.Parse(Console.ReadLine());
        if (sm < 2826.66f || sm > 3751.05f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
        }
        else
        {
            sl = (sm - (sm * 0.15f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);
        }
        break;

    case 4:
        Console.WriteLine("Digite quantos você recebe mensalmente ");
        sm = float.Parse(Console.ReadLine());
        if (sm < 3751.06f || sm > 4664.68f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa ou ultrapassa o valor dessa faixa");
        }
        else
        {
            sl = (sm - (sm * 0.225f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);
        }
        break;

    case 5:
        Console.WriteLine("Digite quantos você recebe mensalmente ");
        sm = float.Parse(Console.ReadLine());
        if (sm < 4664.69f)
        {
            Console.WriteLine("Você não se encaixa nesta faixa");
        }
        else
        {
            sl = (sm - (sm * 0.227f));
            Console.WriteLine("Seu salário liquído é de {0} ", sl);
        }
        break;
            }


