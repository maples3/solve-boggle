using System;
using System.Text;

/**
 * A Boggle board is a unique arrangement of the sixteen dice in a 4x4 grid.
 * NOTE: real-life Boggle has "Qu" instead of just "Q".  The "Qu" combination is represented by the char "q" 
 */
public class BoggleBoard {
    private char[,] _board = new char[0,0];

    public BoggleBoard(char[,] board) {
        // TODO - validate
        _board = board;
    }

    public BoggleBoard(string boardString) {
        // TODO - validate
        var boardArray = new char[4,4];
        for (int i = 0; i < 16; i++) {
            int x = i % 4;
            int y = i / 4;
            boardArray[x,y] = boardString[i];
        }
        _board = boardArray;
    }

    public string getPrintable() {
        var sb = new StringBuilder();
        for (int y = 0; y < 4; y++) {
            for(int x = 0; x < 4; x++) {
                var ch = _board[x,y];
                if (ch == 'q') {
                    sb.Append("Qu ");
                } else {
                    sb.Append(ch.ToString().ToUpper());
                    sb.Append("  ");
                }
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
