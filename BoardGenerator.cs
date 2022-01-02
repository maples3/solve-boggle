using System;
using System.Linq;

public static class BoardGenerator {
    private static Random rng = new Random();
    public static BoggleBoard generateRandomBoard() {
        // This determines the order that we select the dice from the definition array
        var dieOrder = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
        dieOrder = dieOrder.OrderBy(x => rng.Next()).ToArray();

        char[,] newBoard = new char[4,4];
        for(int i = 0; i < 16; i++) {
            int x = i % 4;
            int y = i / 4;
            int dieRoll = rng.Next(0, 5);
            newBoard[x,y] = BoggleDice.dice[dieOrder[i]][dieRoll];
        }
        return new BoggleBoard(newBoard);
    }
}