using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaCalculadora
{
    internal class Calculadora
    {
    Soma funcaoSoma = new Soma();
    Subtracao funcaoSubtracao = new Subtracao();
    Multiplicacao funcaoMultipicacao = new Multiplicacao();
    Divisao funcaoDividir = new Divisao(); 

        private double elemento1;
        private double elemento2;
        private string operacao;

        public string Getoperacao()
        {
            return operacao;
        }

        public void Setoperacao(string value)
        {
            operacao = value;
        }

        public double Getelemento2()
        {
            return elemento2;
        }

        public void Setelemento2(double value)
        {
            elemento2 = value;
        }

        public double Getelemento1()
        {
            return elemento1;
        }

        public void Setelemento1(double value)
        {
            elemento1 = value;
        }

        public double executarOperacao()
        {
            double resultado = 0;
            if (operacao == "+")
            {
                resultado = funcaoSoma.somar(elemento1, elemento2);
            }else if(operacao == "-"){
                resultado = funcaoSubtracao.subtrair(elemento1, elemento2); 
            }else if (operacao == "*"){
                resultado = funcaoMultipicacao.multiplicar(elemento1,elemento2); 
            }else
            {
                resultado = funcaoDividir.dividir(elemento1, elemento2);
            }
                return resultado;
        }
    }
}
