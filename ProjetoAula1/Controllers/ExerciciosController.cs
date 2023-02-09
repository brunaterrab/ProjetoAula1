using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
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
    }

    }



