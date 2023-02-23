using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Options;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace ProjetoAula1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExerciciosController : ControllerBase
    {
        [HttpGet("Exercicio1")]
        public string Exercicio1(int idade1, int idade2, int idade3, int idade4, int idade5)
        {
            var MediaIdades = (decimal)(idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            return "A média das idades é:" + MediaIdades;
        }

        [HttpGet("Exercicio2")]
        public string Exercicio2(decimal NumeroInformado)
        {
            var numero = NumeroInformado % 2;
            if (numero > 0)
            {
                return "O número é impar!";
            }
            else
            {
                return "O número é par!";
            }
        }
        // 01.Escreva um algoritimo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B.
        // A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o valor
        // que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados nas
        // variáveis.


        [HttpGet("Exerciciocasa1")]
        public string Exerciciocasa1(int a, int b)       // int: inteiro; Decimal: decimal; String: texto
        {                                                // booleano bool: true or false; (comparações, if) 
            int c = b;

            a = b;
            b = c;

            return "variavel a : " + a + "variavel b" + b;

        }


        [HttpGet("ExercicioCasa5")]

        public string ExercicioCasa5(string NumeroInformado)    // public string é o que oq o usuario informa
                                                                // entrada
        {
            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(NumeroInformado);
            var antecessor = asciiBytes[0];
            antecessor--; // -- é a mesma coisa que -1
            return ("O antecessor é:" + antecessor);
        }

        [HttpGet("ExercicioCasa6")]

        public string ExercicioCasa6(decimal base1, decimal altura)
        {
            decimal area = base1 * altura;
            return ("A área do retângulo é:" + area);
        }

        [HttpGet("ExercicioCasa7")]

        public string ExercicioCasa7(int anos, int meses, int dias)
        {
            int diasAno = (365 * anos) / 1;      // regra de 3
            int diasMeses = (30 * meses) / 1;
            int idade = diasAno + diasMeses + dias;
            return "A idade da pessoa é:" + idade;
        }

        [HttpGet("ExercicioCasa25")]
        public decimal ExercicioCasa25(decimal salario, decimal vendasEfetuadas)
        {
            decimal resultado = 0;
            if (vendasEfetuadas >= 1500)
            {
                resultado = salario + ((vendasEfetuadas * 5) / 100);
            }

            if (vendasEfetuadas < 1500)
            {
                resultado = salario + ((vendasEfetuadas * 3) / 100);
            }
            return resultado;
        }

        //[HttpGet("ExercicioCasa8")]
        //public string ExercicioCasa8(int votosnulos, int votosbrancos, int votosvalidos, int totalvotos)
        //{
        //decimal percentnulos = votosnulos * totalvotos /100;
        //decimal percentbrancos = votosbrancos * totalvotos /100;
        //decimal percentvalidos = votosvalidos * totalvotos /100;
        //return ("percentual de votos nulos:" + percentnulos + "%", "percentual de votos brancos:" + percentbrancos + "%", "percentual de votos validos:" + percentvalidos + "%");
        //}

        [HttpGet("ExercicioCasa9")]
        public string ExercicioCasa9(decimal salarioAtual, decimal percentReajuste)
        {
            decimal aumento = percentReajuste * salarioAtual / 100;
            decimal novoSalario = salarioAtual + aumento;
            return "O novo salário é: " + novoSalario;
        }

        [HttpGet("ExercicioCasa10")]
        public decimal ExercicioCasa10(decimal custoFabrica)
        {
            decimal percentDist = custoFabrica * 28 / 100;
            decimal percentImp = custoFabrica * 45 / 100;
            decimal custoFinal = percentDist + percentImp;
            return custoFinal;

        }

        [HttpGet("ExercicioCasa11")]
        public string ExercicioCasa11(decimal carrosVendidos, decimal totalVendas, decimal salarioFixo, decimal comissao)
        {
            decimal totalComissao = carrosVendidos * comissao;
            decimal totalComissao2 = totalComissao + (totalVendas * 5 / 100);
            decimal totalSalario = totalComissao2 + salarioFixo;
            return "Salario final do vendedor" + totalSalario;
        }
        [HttpGet("ExercicioCasa14")]
        public string ExercicioCasa14(decimal valor)

        {
            if (valor >= 10)
            {
                return ("O Valor informado é Maior que 10!");
            }
            else
            {
                return ("O Valor informado é Menor que 10!");
            }

        }

        [HttpGet("ExercicioCasa15")]
        public string ExercicioCasa15(decimal valor)
        {
            if (valor >= 0)
            {
                return "positivo";

            }
            else
            {
                return "negativo";
            }
        }

        [HttpGet("ExercicioCasa16")]
        public string ExercicioCasa16(int macasCompradas)
        {

            decimal custoCompra = 0;

            if (macasCompradas >= 12)
            {
                custoCompra = macasCompradas * 1;
            }
            else
            {
                custoCompra = (decimal)(macasCompradas * 1.30);
            }
            return ("O custo total da compra foi de:" + custoCompra);
        }

        [HttpGet("ExercicioCasa17")]
        public string ExercicioCasa17(decimal nota1, decimal nota2)
        {
            decimal media = (nota1 + nota2) / 2;
            if (media >= 6)
            {
                return "você esta aprovado!";
            }
            else
            {
                return "você não foi aprovado";

            }
        }
        [HttpGet("ExercicioCasa18")]
        public string ExercicioCasa18(int anoAtual, int anoNascimento)
        {
            int idade = anoAtual - anoNascimento;
            if (idade >= 18)
            {
                return "você já pode votar";
            }
            else
            {
                return "você ainda não pode votar";
            }
        }
        [HttpGet("ExercicioCasa19")]
        public string ExercicioCasa19(decimal numero1, decimal numero2)
        {
            if (numero1 > numero2)
            {
                return "O numero maior é: numero1!";
            }
            else if (numero2 > numero1)
            {
                return "O numero maior é: numero2!";
            }
            else
            {
                return "Coloque números diferentes!";
            }
        }
        [HttpGet("ExercicioCasa20")]
        public string ExercicioCasa20(decimal valor1, decimal valor2)
        {
            if (valor1 > valor2)
            {
                return "A forma crescente é:" + valor2 + "," + valor1;
            }
            else if (valor2 < valor1)
            {
                return "A forma crescente é:" + valor1 + "," + valor2;
            }
            else
            {
                return "Valores iguais não são lidos!";
            }
        }
        [HttpGet("ExercicioCasa21")]
        public string ExercicioCasa21(int horainicio, int horafim)
        {
            int total = 0;

            if (horafim < horainicio)
            {
                total = (24 - horainicio) + horafim;
            }
            else if (horafim > horainicio)
            {
                total = horafim - horainicio;
            }
            else
            {
                total = 24;
            }
            return "O total de horas jogadas, foram:" + total;
        }

        [HttpGet("Logicos")]
        public string Logicos(int numero)
        {
            //if else
            /*
             Perceba que no if se vc só possuir uma linha abaixo é ela que vai rodar, ou seja se não houve {} ele vai rodar o primeiro comando até o ";" 
            ! = diferente de
            > maior
            > = maior igual
            < = menor igual
            == igual
            !  negar 
             */
            string retorno = "Primeiro Retorno:";
            if ((numero > 5 && numero < 10) || numero < 0)// maior que 5 e menor que 10, ou menor que 0            
                retorno += "primeiro if se for maior que 5 ou menor q 0";
            else if (numero < 7 && numero != 3)// numero menor que 7 e diferente de 3, e so acontece caso ele não caia no primeiro if             
                retorno += "segundo ifelse é menor que 7, e não tem como ser 6 e nem 3 ou menor que 0, senão caia no primeiro if ";
            else//so acontece se não cair nos dois primeiros ifs, provavelmente o numero é maior que 10            
                retorno += "O numero é maior que 10 ou é 3";
            //Operador ternario, esse trecho faz a mesma coisa que o de cima, Como funciona, é aplicado uma logica booleana antes do "?" após o "?" é verdadeiro e após os ":" é quando falso, perceba que quando falso foi feita outra verificação e assim sucessivamente (Lofica ? Verdadeiro : Falso;)
            retorno += " | Segundo Retorno:";
            retorno += ((numero > 5 && numero < 10) || numero < 0) == true ? "primeiro if se for maior que 5 ou menor q 0" : (numero < 7 && numero != 3) == true ? "segundo ifelse é menor que 7, e não tem como ser 6 ou menor que 0, senão caia no primeiro if " : "O numero é maior que 10 ou é 3";
            //Switch case, perceba que ele é mais indicado para trabalhar com valores unicos
            retorno += " | Terceiro Retorno:";
            switch (numero)
            {
                case 1:
                    retorno += "Um";
                    break;
                case 3:
                    retorno += "Tres";
                    break;
                case 4:
                    retorno += "Quatro";
                    break;
                case 5:
                    retorno += "Cinco";
                    break;
                default:
                    retorno += "Outro";
                    break;
            }
            return retorno;
        }


        [HttpGet("ExercicioCasa27")]
        public string ExercicioCasa27(decimal valor)
        {
            // retorno += ((numero > 5 && numero < 10) || numero < 0) == true ? : (numero < 7 && numero != 3) == true ? "segundo ifelse é menor que 7, e não tem como ser 6 ou menor que 0, senão caia no primeiro if " : "O numero é maior que 10 ou é 3";

            string chiquinha = valor > 0 ? "Positivo" : valor < 0 ? "Negativo" : "Zero";

            return chiquinha;
            // Bataman meu ovo
        }

        [HttpGet("ExercicioCasa28")]
        public string ExercicioCasa28(decimal valor1, decimal valor2, decimal valor3)
        {

            if (valor1 > valor2 && valor1 > valor3)
            {
                return "O numero maior é: numero1!";
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                return "O numero maior é: numero2!";
            }
            else
            {
                return "O numero maior é: numero3!";
            }
        }
        // [HttpGet("ExercicioCasa29")]
        //public string ExercicioCasa29(decimal valor1, decimal valor2, decimal valor3)
        //{
        //Ler 3 valores (considere que não serão informados valores iguais) e escrever a soma dos 2 maiores
        //{
        //int meio = 0
        //int inicio = 0
        //int final = 0
        // if (n1>n2) && (n1>n3)
        // 
        //}

        [HttpGet("ExercicioCasa30")]
        public string ExercicioCasa30(int n1, int n2, int n3)
        //30) Ler 3 valores(considere que não serão informados valores iguais) e escrevê-los em ordem crescente.
        {

            if (n1 == n2 || n2 == n3 || n3 == n1)
            {
                return "valores iguais não são permitidos!";
            }

            int menor = 0;
            int meio = 0;
            int maior = 0;

            if (n1 > n2 && n1 > n3)
            {
                maior = n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                maior = n2;
            }
            else
                maior = n3;

            if (n1 < n2 && n1 < n3)
            {
                menor = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                menor = n2;
            }
            else
            {
                menor = n3;
            }
            if (n1 != menor && n1 != maior)
            {
                meio = n1;
            }
            else if (n2 != menor && n2 != maior)
            {
                meio = n2;
            }
            else
            {
                meio = n3;
            }
            return "a ordem crescente é:" + menor + "," + meio + "," + maior;
        }

        //[HttpGet("ExercicioCasa31")]
        // public string ExercicioCasa31(decimal ladoA, decimal ladoB, decimal ladoC)
        //31) Ler 3 valores (A, B e C) representando as medidas dos lados de um triângulo e escrever se formam
        //ou não um triângulo.OBS: para formar um triângulo, o valor de cada lado deve ser menor que a soma
        //dos outros 2 lados.
        // {
        //  if ((ladoA + ladoB) > ladoC || (ladoB + ladoC) > ladoA ||)
        //{
        //    return "Formam um triangulo";
        // }
        // else
        //{
        //    return "Não formam um triangulo";
        //}
        //   if ((ladoB + ladoC) > ladoA)
        // {
        //    return "Formam um triangulo";
        //}
        // else
        // {
        //   return "Não formam um triangulo";
        // }
        //  if ((ladoA + ladoC) > ladoB)
        //  {
        //    return "Formam um triangulo";
        // }
        // else
        // {
        //  return "Não formam um triangulo";
        //}

        // }
        [HttpGet("ExercicioCasa32")]
        public string ExercicioCasa32(string time1, string time2, int golstime1, int golstime2)

        //32) Ler o nome de 2 times e o número de gols marcados na partida (para cada time). Escrever o nome
        //do vencedor.Caso não haja vencedor deverá ser impressa a palavra EMPATE.
        {
            string vencedor = "vazio";

            if (golstime1 > golstime2)
                vencedor = time1;
            else
            {
                vencedor = time2;
            }
            if (golstime2 == golstime1)
            {
                vencedor = "EMPATE!";
            }
            return "O vencedor foi:" + vencedor;
        }


        [HttpGet("ExercicioCasa33")]
        public string ExercicioCasa33(int valor1, int valor2)
        // em ternario 
        // 33) Ler dois valores e imprimir uma das três mensagens a seguir:
        //‘Números iguais’, caso os números sejam iguais
        //‘Primeiro é maior’, caso o primeiro seja maior que o segundo;
        //‘Segundo maior’, caso o segundo seja maior que o primeiro.
        {

            string variavelRetorno = (valor1 > valor2) ? "O numero maior é: numero1!" : (valor2 > valor1) ? "O numero maior é: numero2!" : (valor1 == valor2) ? "O numero é igual!":"";
            return variavelRetorno;
        }
        // [HttpGet("ExercicioCasa35")]
        //public string ExercicioCasa35(intvalor1, int valor2)


        // Um posto está vendendo combustíveis com a seguinte tabela de descontos:
        //até 20 litros, desconto de 3% por litro Álcool acima de 20 litros, desconto de 5% por litro
        //até 20 litros, desconto de 4% por litro Gasolina acima de 20 litros, desconto de 6% por litro
        //Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível(codificado da
        //seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente sabendo-se
        //que o preço do litro da gasolina é R$ 3,30 e o preço do litro do álcool é R$ 2,90.

        // [HttpGet("ExercicioCasa36")]
        //public string ExercicioCasa36(intvalor1, int valor2)

        //Escreva um algoritmo que leia as idades de 2 homens e de 2 mulheres(considere que as idades
        //dos homens serão sempre diferentes entre si, bem como as das mulheres). Calcule e escreva a soma
        //das idades do homem mais velho com a mulher mais nova, e o produto das idades do homem mais
        //novo com a mulher mais velha.

        // [HttpGet("ExercicioCasa37")]
        //public string ExercicioCasa37(intvalor1, int valor2)

        //Uma fruteira está vendendo frutas com a seguinte tabela de preços:
        //Até 5 Kg Acima de 5 Kg
        //Morango R$ 2,50 por Kg R$ 2,20 por Kg
        //Maçã R$ 1,80 por Kg R$ 1,50 por Kg
        //Se o cliente comprar mais de 8 Kg em frutas ou o valor total da compra ultrapassar R$ 25,00, receberá
        //ainda um desconto de 10% sobre este total.Escreva um algoritmo para ler a quantidade(em Kg) de
        //morangos e a quantidade(em Kg) de maças adquiridas e escreva o valor a ser pago pelo cliente.

        [HttpGet("Repeticao")]
        public string LacosRepeticao(int[] itens)        
        {
            string retorno = "";
            int[] idades= new int[6] { 1, 4, 9, 12, 33, 14 };
            retorno += " FOR ";
            for (int z=0;z<idades.Length; z++)//REPITA
            {
                // FOR 1, 4, 9, 12, 33, 14                
                retorno += idades[z] + ",";

                idades[z] = z;
            }
            retorno += " WHILE ";
            int i = 0;
            while(i < idades.Length)//ENQUANTO
            {
                //while 0, 4, 9, 12, 33, 14
                //retorno += idades[i] + ",";

                idades[i] = i;
                i++;
            }

            return retorno;

        }
        // receber uma lista de vetores inteiros e multiplicar por dois e retornar a lista como uma string
        [HttpPost("Repeticao2")]
        public string LacosRepeticao2(int[] itens)
        {
            string retorno = "";
            // 0,1,2,3,4,5
            for (int i = 0; i < itens.Length; i++)
            {
                int b = itens[i] * 2;
                retorno += b + ",";
            }
            return retorno;
        }
        [HttpPost("Repeticao2While")]
        public string LacosRepeticaoWhile(int[] itens)
        {
            string retorno = "";
            // 0,1,2,3,4,5
            int i = 0;
            while (i<itens.Length)
            {
                int b = itens[i] * 2;
                retorno += b + ",";
                i++;
            }
            return retorno;
        }
    }



}







