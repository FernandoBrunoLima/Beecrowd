// frequencia 21/11

namespace Aula2111
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] trechos = { "ra", "re", "ro", "ma", "to" };
            string[] vogais = {"a", "e", "i", "o", "u"};

            string artigo = vogais[3];
            string palavra1 = trechos[0] + trechos[4];
            string palavra2 = trechos[1] + vogais[2];

            string palavra3 = trechos[2] + vogais[1];
            palavra3 += vogais[4];

            string frase = $"{artigo} {palavra2} {palavra3} {artigo} {palavra1}";
            Console.WriteLine( frase );
        }
    }
}
