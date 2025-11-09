/* 
Enunciado:

Faça um programa que possa ser usado por uma clínica para cadastrar: 30 pacientes, a data da consulta, a hora de sua realização, o nome de um paciente e o nome do médico que o atenderá. Depois de os dados serem informados, o programa deve conter uma opção que, o usuário fornecendo o nome do médico, liste toda a agenda dele.

Considere que o atributo Data da consulta” seja também estruturado, formado pelos campos Dia, Mês e Ano. 

*/

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkBJA
{
    class Paciente
    {
        public string NomePaciente;
        public string NomeMédico;
        public Data DataConsulta;
        public string HoraConsulta;
    }
    class Data
    {
        public string Dia;
        public string Mês;
        public string Ano;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Cadastro de 30 Pacientes
            // Informações sobre Data e Hora da Consulta, Paciente e Médico
            // Listagem de toda a agenda do médico segundo seu nome
            Paciente[] Cadastro = new Paciente[3]; // Vetor com 3 posições para teste...
            for (int i = 0; i < 3; i++)
            {
                Paciente x = new Paciente(); // Objeto - Instância
                Console.Write($"\nNome do Paciente nr. {i + 1}: ");
                x.NomePaciente = Console.ReadLine();
                Console.Write("Médico................: ");
                x.NomeMédico = Console.ReadLine();
                x.DataConsulta = new Data(); 
            Console.Write("Data da Consulta - Dia: ");
                x.DataConsulta.Dia = Console.ReadLine();
                Console.Write(" Mês: ");
                x.DataConsulta.Mês = Console.ReadLine();
                Console.Write(" Ano: ");
                x.DataConsulta.Ano = Console.ReadLine();
                Console.Write("Hora da Consulta......: ");
                x.HoraConsulta = Console.ReadLine();
                Cadastro[i] = x; // Cadastro feito.
            }
            Console.Clear();
            string NomeMédico;
            Console.Write("Digite o Nome de um Médico: ");
            NomeMédico = Console.ReadLine();
            foreach (Paciente P in Cadastro)
            {
                if (P.NomeMédico == NomeMédico)
                {
                    Console.WriteLine($"\nPaciente: {P.NomePaciente}");
                    Console.WriteLine($"{P.DataConsulta.Dia}/" +
                    $"{P.DataConsulta.Mês}/" +
                    $"{P.DataConsulta.Ano} - " +
                    $"{P.HoraConsulta} Horas");
                }
            }
            Console.ReadKey();
        }
    }
}