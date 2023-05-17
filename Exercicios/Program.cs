using System.Globalization;
// Exercícios sobre Estrutura Sequencial (entrada, processamento, saída)

#region Ex - 01
//Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma 
//mensagem explicativa, conforme exemplos 

/*
Console.WriteLine("Informe um valor inteiro: ");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe outro valor inteiro: ");
int valor2 = int.Parse(Console.ReadLine());

int soma = valor1 + valor2;

Console.WriteLine($"A soma entre {valor1} e {valor2} é igual a: {soma}");
*/
#endregion

#region Ex - 02

//Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
//casas decimais conforme exemplos.
//Fórmula da área: area = π.raio2
//Considere o valor de π = 3.14159

/*
Console.WriteLine("Informe o raio do círculo: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = Math.PI * Math.Pow(raio, 2);

Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
*/
#endregion

#region Ex - 03

//Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
//de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D)

/*
Console.WriteLine("Informe o valor de A: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de B: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de C: ");
int c = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de D: ");
int d = int.Parse(Console.ReadLine());

int diferenca = a * b - c * d;

Console.WriteLine($"diferença = {diferenca}");
*/
#endregion

#region Ex - 04
//Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
//hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
//decimais

/*
Console.WriteLine("Informe o número do funcionário: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a quantidade de horas trabalhadas");
int horasTrabalhadas = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor recebido por hora: ");
decimal valorHora = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

decimal salario = valorHora * horasTrabalhadas;

Console.WriteLine($"NUMBER = {numero}\nSALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
*/
#endregion

#region Ex - 05
//Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
//código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

/*
Console.WriteLine("Informe o código da peça, a quantidade de peças e o valor unitário separado por espaço: ");
string[] peca1 = Console.ReadLine().Split(' ');
int codigoPeca1 = int.Parse(peca1[0]);
int quantidadePeca1 = int.Parse(peca1[1]);
decimal valorPeca1 = decimal.Parse(peca1[2], CultureInfo.InvariantCulture);

Console.WriteLine("Informe o código da peça dois, a quantidade de peças e o valor unitário separado por espaço: ");
string[] peca2 = Console.ReadLine().Split(' ');
int codigoPeca2 = int.Parse(peca2[0]);
int quantidadePeca2 = int.Parse(peca2[1]);
decimal valorPeca2 = decimal.Parse(peca2[2], CultureInfo.InvariantCulture);

decimal valor = (quantidadePeca1 * valorPeca1) + (quantidadePeca2 * valorPeca2);

Console.WriteLine($"VALOR A PAGAR: R$ {valor.ToString("F2", CultureInfo.InvariantCulture)}");
*/
#endregion

#region Ex - 06
//Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
//a) a área do triângulo retângulo que tem A por base e C por altura. 
//b) a área do círculo de raio C. (pi = 3.14159) 
//c) a área do trapézio que tem A e B por bases e C por altura. 
//d) a área do quadrado que tem lado B. 
//e) a área do retângulo que tem lados A e B.

/*
Console.WriteLine("Informe os valores de A, B e C. separados por espaço: ");
string[] valores = Console.ReadLine().Split(' ');
double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

double triangulo = (a * c) / 2;
double circulo = Math.PI * Math.Pow(c, 2);
double trapezio = (a + b) * c / 2;
double quadrado = Math.Pow(b, 2);
double retangulo = a * b;

Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}" +
    $"\nCIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}" +
    $"\nTRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}" +
    $"\nQUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}" +
    $"\nRETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
*/
#endregion

// Exercícios sobre Estrutura Condicional (if-else)

#region Ex - 01
//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

/*
Console.WriteLine("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

if (numero < 0 )
{
    Console.WriteLine("NEGATIVO");
}
else
{
    Console.WriteLine("NÃO NEGATIVO");
}
*/
#endregion

#region Ex - 02
//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpa

/*
Console.WriteLine("Informe um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

if(numero % 2 == 0 )
{
    Console.WriteLine("PAR");
}
else 
{
    Console.WriteLine("IMPAR");
}
*/
#endregion

#region Ex - 03
//Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao 
//Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em 
//ordem crescente ou decrescente.

/*
Console.WriteLine("Informe dois número inteiros separados por espaço: ");
string[] numeros = Console.ReadLine().Split(' ');
int a = int.Parse(numeros[0]);
int b = int.Parse(numeros[1]);

if(a % b == 0 || b % a == 0)
{
    Console.WriteLine("São Multiplos");
}
else
{
    Console.WriteLine("Não são Multiplos");
}
*/
#endregion

#region Ex - 04
//Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode 
//começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas

/*
Console.WriteLine("Informe a hora inicial e a hora final do jogo separadas por espaço: ");
string[] horas = Console.ReadLine().Split(' ');
int horaInicial = int.Parse(horas[0]);
int horaFinal = int.Parse(horas[1]);
int duracao;

if (horaInicial < horaFinal)
{
    duracao = horaFinal - horaInicial;   
} else
{
    duracao = 24 - horaInicial + horaFinal;
}

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
*/
#endregion

#region Ex - 05
//Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A 
//seguir, calcule e mostre o valor da conta a pagar

/*
Console.WriteLine("Informe o codigo do item e a quantidade separada por espaço: ");
string[] pedido = Console.ReadLine().Split(' ');
int codigo = int.Parse(pedido[0]);
int quantidade = int.Parse(pedido[1]);

decimal valorConta = 0;
if (codigo == 1)
{
    valorConta = quantidade * 4.0m;
} 
else if (codigo == 2)
{
    valorConta =  quantidade *4.50m;
}
else if (codigo == 3)
{
    valorConta = quantidade * 5.00m;
}
else if (codigo == 4)
{
    valorConta =  quantidade * 2.00m;
}
else if (codigo == 5)
{
    valorConta =  quantidade * 1.50m;
}
else 
{
    Console.WriteLine("Código invalido");
}

Console.WriteLine($"Total: R$ {valorConta.ToString("F2", CultureInfo.InvariantCulture)}");
*/
#endregion

#region Ex - 06
//Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos 
//seguintes intervalos([0,25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em 
//nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

/*
Console.WriteLine("Informe um valor: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

if(valor >= 0 && valor <= 25)
{
    Console.WriteLine("Intervalo [0,25]");
}
else if (valor > 25 && valor <= 50)
{
    Console.WriteLine("Intervalo [25,50]");
}
else if (valor > 50 && valor <= 75)
{
    Console.WriteLine("Intervalo [05,75]");
}
else if (valor > 75 && valor <= 100)
{
    Console.WriteLine("Intervalo [75,100]");
}
else
{
    Console.WriteLine("Fora de intervalo");
}
*/
#endregion

#region Ex - 07
//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas 
//de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o 
//ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
//Se o ponto estiver na origem, escreva a mensagem “Origem”.
//Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação

/*
Console.WriteLine("Informe 2 valores (x e y) separados por espaço: ");
string[] valores = Console.ReadLine().Split(' ');
double x = double.Parse(valores[0]);
double y = double.Parse(valores[1]);

 if (x == 0 && y == 0)
{
    Console.WriteLine("Origem");
}
else if (x == 0 )
{
    Console.WriteLine("Eixo Y");
} 
else if(y == 0 )
{
    Console.WriteLine("Eixo X");
}
else if(x > 0 && y > 0)
{
    Console.WriteLine("Q1");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("Q2");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("Q3");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Q4");
}
*/
#endregion

#region Ex - 08
//Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
//que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem 
//qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
//Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
//mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
//Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de 
//salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é 
//de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com 
//duas casas decimais

/*
Console.WriteLine("Informe o salário salário: ");
decimal salario = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

decimal imposto = 0.0m;
if (salario >= 0.00m && salario <= 2000.00m)
{
    imposto = 0.0m;
}
else if (salario <= 3000.00m)
{
     imposto = (salario - 2000.00m) * 0.08m;
}
else if (salario <= 4500.00m)
{
    imposto = ((salario - 3000.00m) * 0.18m ) + (1000.00m * 0.08m);

}
else if (salario > 4500.00m)
{
    imposto = ((salario - 4500.00m) * 0.28m) + (1500.00m * 0.18m) + (1000.00m * 0.08m);

}

if (imposto == 0.0m )
{
    Console.WriteLine("Insento");
}else
{
    Console.WriteLine($"R$ {imposto.ToString("F2", CultureInfo.InvariantCulture)}");
}
*/
#endregion

// Exercícios sobre Estrutura Repetitiva WHILE

#region Ex - 01
//Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
//incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
//impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.

/*
int senha = 0;

while (senha != 2002)
{
    Console.WriteLine("Informe a senha: ");
    senha = int.Parse(Console.ReadLine());
    if (senha != 2002)
    {
        Console.WriteLine("Senha invalida");
    }
}

Console.WriteLine("Acesso permitido!");
*/
#endregion

#region Ex - 02
//Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
//cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
//menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).

/*
Console.WriteLine("Informe os valores de x e y separados por espaço");
string[] cordenadas = Console.ReadLine().Split(' '); 
int x = int.Parse(cordenadas[0]);
int y = int.Parse(cordenadas[1]);

while (x != 0 && y != 0) 
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("primeiro");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("segundo");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("terceiro");
    }
    else
    {
        Console.WriteLine("quarto");
    }
    cordenadas = Console.ReadLine().Split(' ');
    x = int.Parse(cordenadas[0]);
    y = int.Parse(cordenadas[1]);
}
*/
#endregion

#region Ex - 03
//Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
//um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
//4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
//que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
//mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme 
//exemplo

/*
Console.WriteLine("Informe o tipo de combustível");
int tipo = int.Parse(Console.ReadLine());

int alcool = 0;
int gasolina = 0;
int diesel = 0;

while (tipo !=4)
{
    if(tipo == 1)
    {
        alcool++;
    } else if(tipo == 2)
    {
        gasolina++;
    } else if(tipo == 3)
    {
        diesel++;
    }

    Console.WriteLine("Informe o tipo de combustível");
    tipo = int.Parse(Console.ReadLine());
}

Console.WriteLine($"MUITO OBRIGADO\nAlcool: {alcool}\r\nGasolina: {gasolina}\r\nDiesel: {diesel}");
*/
#endregion