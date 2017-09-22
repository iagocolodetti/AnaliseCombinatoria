using System.Linq;
using System.Numerics;

namespace Análise_Combinatória
{
    class AnaliseCombinatoria
    {
        public BigInteger Fatorial(int n)
        {
            if (n < 0) return 0;
            else if (n == 0) return 1;
            else if (n == 1) return n;
            else return (n * Fatorial(n - 1));
        }

        public BigInteger PermutacaoSimples(int n)
        {
            return Fatorial(n);
        }

        public BigInteger PermutacaoRepeticao(int n, int[] p)
        {
            if (n < p.Sum()) return 0;
            BigInteger resultado, pp = 1;
            for (int i = 0; i < p.Length; i++) pp *= Fatorial(p[i]);
            resultado = (Fatorial(n) / pp);
            if (resultado < 0) resultado = 0;
            return resultado;
        }

        public BigInteger ArranjoSimples(int n, int p)
        {
            if (n < p) return 0;
            BigInteger resultado = (Fatorial(n) / Fatorial(n - p));
            if (resultado < 0) resultado = 0;
            return resultado;
        }

        public BigInteger ArranjoRepeticao(int n, int p)
        {
            if (p < 0) return 0;
            else if (p == 0) return 1;
            else if (p == 1) return n;
            else return (n * ArranjoRepeticao(n, p - 1));
        }

        public BigInteger CombinacaoSimples(int n, int p)
        {
            if (n < p) return 0;
            BigInteger resultado = (Fatorial(n) / (Fatorial(n - p) * Fatorial(p)));
            if (resultado < 0) resultado = 0;
            return resultado;
        }

        public BigInteger CombinacaoRepeticao(int n, int p)
        {
            BigInteger resultado = (Fatorial(n + p - 1) / (Fatorial(n - 1) * Fatorial(p)));
            if (resultado < 0) resultado = 0;
            return resultado;
        }
    }
}
