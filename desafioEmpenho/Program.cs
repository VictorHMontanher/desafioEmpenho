using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            string nivel;

            Console.WriteLine("Insira seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira sua experiência: ");
            int exp = int.Parse(Console.ReadLine());

            if (exp < 1000) {
                nivel = "Ferro";
            } else if ((exp > 1001) && (exp < 2000)) {
                nivel = "Bronze";
            } else if ((exp > 2001) && (exp < 5000)) {
                nivel = "Prata";
            } else if ((exp > 5001) && (exp < 7000)) {
                nivel = "Ouro";
            } else if ((exp > 7001) && (exp < 8000)) {
                nivel = "Platina";
            } else if ((exp > 8001) && (exp < 9000)) {
                nivel = "Diamante";
            } else if ((exp > 9001) && (exp < 10000)) {
                nivel = "Ascendente";
            } else {
                nivel = "Imortal";
            }

            Console.WriteLine("O Herói " + nome + " está no nível " + nivel);

        }
    }
}