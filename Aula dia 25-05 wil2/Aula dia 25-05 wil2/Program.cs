using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_dia_25_05_wil2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //datas
            //DateTime hoje = DateTime.Today;
            //Console.WriteLine("Data e hora atual : "+hoje);
            //DateTime aniversario = new DateTime(2026, 7, 14);
            //Console.WriteLine("Minha data de aniversário : " + aniversario);

            //criando uma data e hora
            //DateTime nascimento = new DateTime(2008, 7, 14, 00, 17, 00);
            //Console.WriteLine("Minha data e hora de nascimento : " + nascimento);

            /*
            dd -> dia
            MM -> mês
            yyyy -> ano
            HH -> hora
            mm -> minuto
            ss -> segundo
            //*/
            //DateTime data = DateTime.Now;
            //Console.WriteLine(data.ToString("dd/MM/yyyy"));
            //Console.WriteLine(data.ToString("dd-MM-yyyy"));
            //Console.WriteLine(data.ToString("HH:mm:ss"));
            //Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));


            //DateTime hoje = DateTime.Now;
            //Console.WriteLine("Hoje: " +hoje);
            //Console.WriteLine("Mais 10 dias: " +hoje.AddDays(10));
            //Console.WriteLine("Mais 2 meses: " +hoje.AddMonths(2));
            //Console.WriteLine("mais 2 anos: " +hoje.AddYears(2));
            //Console.WriteLine("Hoje : 5 dias" +hoje.AddDays(5));

            //Console.WriteLine("Digite uma data (dd/MM/yyyy): ");
            //DateTime data = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Você digitou: " + data.ToString("dd/MM/yyyy"));

            Console.WriteLine("Digite o ano do seu nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - anoNascimento;
            Console.WriteLine("Idade: " + idade);
            //Console.WriteLine("Digite o mês do seu nascimento: ");
            //int mesNascimento = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o dia do seu nascimento: ");
            //int diaNascimento = int.Parse(Console.ReadLine());
            //Console.WriteLine("Você nasceu em: " + diaNascimento + "/" + mesNascimento + "/" + anoNascimento);

        }
    }
}
