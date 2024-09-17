
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static System.Console;


namespace Letreiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vFrase;
            int vTam;
            int Tempo = 0;


            ForegroundColor = ConsoleColor.White;
            BackgroundColor = ConsoleColor.DarkCyan;
            Clear();

            SetCursorPosition(45, 2);
            WriteLine("Seja bem vindo ao Letreiro");
            SetCursorPosition(38, 3);
            WriteLine("========================================");
            SetCursorPosition(45, 4);
            WriteLine("    Digite Uma Frase: ");
            SetCursorPosition(67, 4);
            vFrase = ReadLine();
            WriteLine("Deseja mostrar a frase por quantos segundos? ");
            int TempoEscrito = int.Parse(ReadLine());
            int TempoFrase = TempoEscrito * 750;

            vTam = vFrase.Length;
            string espacos = new string(' ', vTam);
            string vFraseEspaco = vFrase + espacos;
            Clear();


            int bracketWidth = vTam + 6;

            do
            {
                for (int i = 0; i < 1; i++)
                {

                    Clear();
                    SetCursorPosition(0, (WindowHeight / 2) - 7);
                    WriteLine("===================== Letreiro =====================".PadLeft((WindowWidth - 52) / 2 + 52));
                    WriteLine("====================================================".PadLeft((WindowWidth - 52) / 2 + 52));


                }
                int position = (WindowWidth - bracketWidth) / 2;
                string texto = vFraseEspaco;
                char primeiroChar = texto[0];
                SetCursorPosition((position) - 1, (WindowHeight / 2) - 4);
                WriteLine("[ ");
                SetCursorPosition(position, (WindowHeight / 2) - 4);
                Write(texto);
                Write("]");
                vFraseEspaco = vFraseEspaco.Substring(1) + primeiroChar;
                Thread.Sleep(150);
                Tempo = Tempo + 150;
            } while (Tempo < TempoFrase);

            Clear();
            WriteLine("O tempo acabou!");
            ReadKey();
        }
    }
}