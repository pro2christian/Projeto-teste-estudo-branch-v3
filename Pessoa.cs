using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Pessoa
    {   //propiedades
        public double peso, altura;

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
        public void Dados()
        {   //recebe calculo
            double obterCaulculo = calculo();
            //recebe situação
            string obeterSituacao = situacao(obterCaulculo);
                       
        }
    }
        

}

    
    

