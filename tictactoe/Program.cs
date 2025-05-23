using System;
using TicTacToe.Events;
using TicTacToe.Utils;

namespace TicTacToe
{
    static class Program
    {
        static void Main()
        {
            OnPlayerJoinEvent.StartMenu();
            int[][] winCombos = new int[][]
{
    new int[] {0,1,2},
    new int[] {3,4,5},
    new int[] {6,7,8},
    new int[] {0,3,6},
    new int[] {1,4,7},
    new int[] {2,5,8},
    new int[] {0,4,8},
    new int[] {2,4,6}
};

            /*
            [Início IA]
                ↓
            [Verificar se pode vencer]
                ↓ Sim
            [Jogada para vencer] → [Fim Jogada IA]
                ↓ Não
            [Verificar se precisa bloquear]
                ↓ Sim
            [Jogada para bloquear] → [Fim Jogada IA]
                ↓ Não
            [Meio livre?]
                ↓ Sim
            [Jogada no meio] → [Fim Jogada IA]
                ↓ Não
            [Cantos livres?]
                ↓ Sim
            [Jogada em canto] → [Fim Jogada IA]
                ↓ Não
            [Escolher posição aleatória livre]
                ↓
            [Fim Jogada IA]

            */

        }
    }
}
