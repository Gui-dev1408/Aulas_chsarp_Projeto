using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_dia25_05
{
    internal class Program
    { //funçoes 

        //static void Mostrarmenu()//(parametros)
        //{
        //    Console.WriteLine("===== MENU =====");
        //    Console.WriteLine("1 - Cadastrar");
        //    Console.WriteLine("2 - Listar");
        //    Console.WriteLine("3 - Sair");
        //}
        static int dobro(int n)
        {
            return n * 2;
        }
        static int somar(int n1, int n2)
        {
            return (n1 + n2);
        }
        static string Saudacao(string nome)
        {
            return "Olá " + nome + ", Seja bem vindo!";

        }
        static bool Aprovado(double nota)
        {
            return nota >= 7;
        }
        static void Main(string[] args)
        {
            //Mostrarmenu();
            //int resultado;
            //resultado = dobro(10);
            //    //Console.WriteLine("Dobro = " + resultado);
            //    int valor1, valor2;
            //    Console.WriteLine("Digite o primeiro numero :");
            //    valor1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o segundo numero :");
            //    valor2 = int.Parse(Console.ReadLine());

            //    int resultado;
            //    resultado = valor1 + valor2;
            //    Console.WriteLine("A soma de n1 + n2 é = "+resultado);

            //string nome;
            //Console.WriteLine("Digite o seu nome: ");
            //nome = Console.ReadLine();
            //Console.WriteLine(Saudacao(nome));

            //Console.WriteLine("Digite a nota do aluno: ");
            //double nota = double.Parse(Console.ReadLine());

            //bool resultado = Aprovado(nota);
            //if (resultado) //recebe true ou false
            //{
            //    //se for verdadeiro então o aluno está aprovado
            //    Console.WriteLine("Aluno Aprovado!");
            //}
            //else
            //{
            //    //se for falso então o aluno está reprovado
            //    Console.WriteLine("Aluno Reprovado!");
            //}
            //Recursiva r =new Recursiva();
            //r.Executar("Ti101", 5);
            

        }
        //public class Recursiva
        //{
        //    public void Executar(string mensagem, int n)
        //    {
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine(i);
        //        }

        //    }
        //    public void ExecutarRecursiva(string mensagem ,int n)
        //    {
        //        if(n> 0)
        //        {
        //            Console.WriteLine(mensagem);
        //            ExecutarRecursiva(mensagem, n - 1);
        //        }   
                
                
        //    }
        //}      
        public class Recursiva
        {
            
        }
        static void contagem(int Numero)
        {
           if(Numero >=0)
            {
                Console.WriteLine(Numero);
                contagem(Numero - 1);
                Console.ReadKey();
            }
        }
    }
}

