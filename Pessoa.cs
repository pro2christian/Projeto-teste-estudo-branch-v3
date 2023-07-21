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
            return peso / (altura*altura);
        }

        public string situacao(int imc)
        {   //variavel
            string retorno;

            if (imc < 18.5)
            {
                retorno = "Abaixo do peso";
            } else if ()
            {

            }

        }

    }
    

}
