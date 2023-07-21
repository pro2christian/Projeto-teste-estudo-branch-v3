using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Pessoa
    {   //propiedades
        public double peso, altura;
        public string nome ="";

        //calculo
        public double calculo()
        {
            return peso / (altura * altura);
        }

        public string situacao(double imc)
        {   //variavel
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            }
            else if (imc < 24.9)
            {
                retorno = "Peso normal";

            }
            else if (imc < 29.9)
            {
                retorno = "Excesso de peso";
            }
            else if (imc < 34.9)
            {
                retorno = "Obsidade classe I";
            }
            else if (imc < 39.9)
            {
                retorno = "Obsidade classe II";

            }
            else
            {
                retorno = "Obsidade classe III";
            }
            //retorno
            return retorno;
        }
        public string tabela()
        {
            string lista = "\r\nEntenda o seu resultado" +
            "\r\nAcima de 40,0. Obesidade. grau III. ..." +
            "\r\nEntre 35,0 e 39,9. Obesidade. grau II. ..." +
            "\r\nEntre 30,0 e 34,9. Obesidade grau I. Sinal de alerta! ..." +
            "\r\nEntre 25,0 e 29,9. Sobrepeso. ..." +
            "\r\nEntre 18,6 e 24,9. Normal. ..." +
            "\r\n18,5 ou menos. Abaixo do normal.";
            return lista;
        }
        public void dados()
        {   //recebe calculo
            double obterCalculo = calculo();
            //recebe situação
            string obeterSituacao = situacao(obterCalculo);
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine("Seu imc é de " +  obterCalculo.ToString("N2"));
            Console.WriteLine("Sua situação é " + obeterSituacao.ToUpper());
            Console.WriteLine(tabela().ToUpper());
        }
      
    }
        

}

    
    

