//Atividade 1 


float investimento = 1000;
float variação_dia1 = -3.4f;
float variação_dia2 = 2.8f;
float variação_dia3 = 14f;
float variação_dia4 = -8.5f;

float valor_dia1 = investimento * (1 + variação_dia1 / 100);
float valor_dia2 = valor_dia1 * (1 + variação_dia2 / 100);
float valor_dia3 = valor_dia2 * (1 + variação_dia3 / 100);
float valor_atual = valor_dia3 * (1 + variação_dia4 / 100);

Console.WriteLine("O valor atual dos investimentos de Marquesito é R$" + valor_atual.ToString("0.00"));


//Atividade 2 

Console.WriteLine("Digite seu salário: ");
float salário = int.Parse(Console.ReadLine());
float aumento = salário * 0.25f;
float total = salário + aumento;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));

//Atividade 3 

Console.WriteLine("Digite o número desejado: ");
int numero = int.Parse(Console.ReadLine());
numero = (numero * 3 + 1) + (numero * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numero.ToString());




//atividade 4 

Console.WriteLine("Digite a primeira nota: ");
float nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
float peso1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota: ");
float nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da segunda nota: ");
float peso2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota: ");
float nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da terceira nota: ");
float peso3 = float.Parse(Console.ReadLine());
float inteiro;

inteiro = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / (peso1 + peso2 + peso3);
Console.WriteLine("A média poderada dos pesos é: " + inteiro.ToString());


//atividade 5 - lista

Console.WriteLine("Digite a distância percorrida: ");
float distância = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o tempo que foi gasto na ação em segundos: ");
float tempo = float.Parse(Console.ReadLine());
float velocidade;

velocidade = (distância / tempo);
Console.WriteLine("A velocidade em a ocorreu a ação foi de: " + velocidade.ToString());


// atividade 6 

Console.WriteLine("Digite seu salário: ");
float salários = int.Parse(Console.ReadLine());
float aumentos = salários * 0.25f;
float totais = salários + aumentos;
Console.WriteLine("O salário pós aumento é " + total.ToString("0.00"));

// atividade 7

Console.WriteLine("Digite o valor a ser convertido em reais: ");
double real = double.Parse(Console.ReadLine());
double valor_dolar = 4.97;
double dolar;

//atividade 8 

Console.WriteLine("Digite o número desejado: ");
int numeros = int.Parse(Console.ReadLine());
numeros = (numeros * 3 + 1) + (numeros * 2 - 1);
Console.WriteLine("A soma do sucessor do triplo com o antecessor do dobro é: " + numeros.ToString());


//aividade 9
int val,milhar, milhar1, milhar2, centena1, centena2, dezena1, dezena2, unidade1, unidade2, vall1, vall2;

Console.WriteLine("Digite um número de quatro digítos: ");

val = int.Parse(Console.ReadLine());
milhar1 = val / 1000;
milhar2 = milhar1 * 1000;
centena1 = (val - milhar1) / 1000;
centena2 = centena1 * 100;
vall1 = milhar2 + centena1;
dezena1 = (val - vall1) / 10;
dezena1 = dezena1 * 10;
vall2 = milhar1 + centena1 + dezena1;
unidade1 = val - vall2;

Console.WriteLine("{0}\n{1}\n{2}\n{3}", milhar1, centena1, dezena1, unidade1);

// atividade 10 

float investimentos = 1000.0f;
float variação_dia10 = -3.4f;
float variação_dia20 = 2.8f;
float variação_dia30 = 14f;
float variação_dia40 = -8.5f;

float valor_dia10 = investimentos * (1 + variação_dia10 / 100);
float valor_dia20 = valor_dia1 * (1 + variação_dia2 / 100);
float valor_dia30 = valor_dia2 * (1 + variação_dia3 / 100);
float valor_atual0 = valor_dia3 * (1 + variação_dia4 / 100);

Console.WriteLine("O valor atual dos investimentos de Marquesito é R$" + valor_atual.ToString("0.00"));

//atividade 11

Console.WriteLine("Digite o número desejado: ");
float num = float.Parse(Console.ReadLine());
float quadrado;
float cubo;

quadrado = (num * num);
cubo = (num * num * num);

Console.WriteLine("O número ao quadrado é: {0} \n O resultado ao cubo é: {1}", quadrado, cubo);

//atividade 12

Console.WriteLine("Digite sua altura: ");
float altura1 = float.Parse(Console.ReadLine());
double ideal1;
double ideal2;


ideal1 = (72.7 * altura1 - 58);
ideal2 = (62.1 * altura1 - 44.7);

Console.WriteLine("Para mulher, o peso ideal é: {0} \n Para homem, o peso ideal é: {1}", ideal2, ideal1);

//atividade 13

Console.WriteLine("O github é quase como uma rede social dev, utilizado para compartilhar ideias e projetos, podendo até ser utilizado para pegar projetos prontos e apeerfeiçoa-los, já o git é um programa param armazenar arquivos sendo possível ver todas as atualizações mais recentes e também passadas do projetos. \n Alguns comandos do git são: git config, git init, git clone, git add, git commit, git branch, git checkout, git remote, git push, git fetch");
