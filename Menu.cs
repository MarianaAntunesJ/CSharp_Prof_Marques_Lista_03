using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_03
{
    class Menu
    {
        static public void MenuOpcoes()
        {
            int resp;
            do
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine(" 1 - Soma de matrizes;");
                Console.WriteLine(" 2 - Matriz transposta;");
                Console.WriteLine(" 3 - Busca elemento na matriz;");
                Console.WriteLine(" 4 - Elementos acima da diagonal principal;");
                Console.WriteLine(" 5 - Soma diagonal prin. e soma diagonal sec.;");
                Console.WriteLine(" 6 - M[i][j];");
                Console.WriteLine(" 7 - Multiplica por par p/ 5 e ímpar p/ 3;");
                Console.WriteLine(" 8 - Porcentagem;");
                Console.WriteLine(" 9 - Primos;");
                Console.WriteLine("10 - Desafio;");
                Console.WriteLine(" 0 - Sair;\n");
                Console.Write("opção: ");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Perguntas.Pergunta01();
                        break;
                    case 2:
                        Perguntas.Pergunta02();
                        break;
                    case 3:
                        Perguntas.Pergunta03();
                        break;
                    case 4:
                        Perguntas.Pergunta04();
                        break;
                    case 5:
                        Perguntas.Pergunta05();
                        break;
                    case 6:
                        Perguntas.Pergunta06();
                        break;
                    case 7:
                        Perguntas.Pergunta07();
                        break;
                    case 8:
                        Perguntas.Pergunta08();
                        break;
                    case 9:
                        Perguntas.Pergunta09();
                        break;
                    case 10:
                        Perguntas.Pergunta10();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } while (resp != 0);
        }
    }
}
