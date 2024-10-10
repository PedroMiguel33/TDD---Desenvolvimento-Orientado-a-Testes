using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNewTalents
{
    public class Calculadora
    {
        private List<string> historicoOperacoes;

        public Calculadora()
        {
            historicoOperacoes = new List<string>();
        }
        public int Somar(int num1, int num2)
        {
            int resultado = num2 + num1;
            historicoOperacoes.Insert(0, "Resultado: " + resultado);
            return resultado;

        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            historicoOperacoes.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            historicoOperacoes.Insert(0, "Resultado: " + resultado);
            return resultado;
        }
        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            historicoOperacoes.Insert(0, "Resultado: " + resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            
            historicoOperacoes.RemoveRange(3, historicoOperacoes.Count - 3);
            return historicoOperacoes;
        }

    }
}
