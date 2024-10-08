﻿using System.Linq.Expressions;
using tabuleiro;
using xadrez;



namespace xadrez_console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();    
                
                while(!partida.terminada)
                {
                    try
                    {
                        Console.Clear();

                        Tela.ImprimirPartida(partida);
                       
                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.tab, posicoesPossiveis);
                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);   
                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine();
                        Console.Write("Aperte 'Enter' e escolha novamente");
                        Console.ReadKey();  
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partida);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            /*
           PosicaoXadrez pos = new PosicaoXadrez('a', 1 );

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            */



        }
    }
}