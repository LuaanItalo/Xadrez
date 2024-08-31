using System.Linq.Expressions;
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
                    Console.Clear();

                    Tela.ImprimirTabuleiro(partida.tab);
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.executaMovimneto(origem, destino);  
                }
             



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