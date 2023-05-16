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