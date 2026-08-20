public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] squares = new HashSet<char>[9];

        for(int i = 0; i < 9; i++) {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            squares[i] = new HashSet<char>();
        }

        for(int i = 0; i < 9; i++) {
            for(int j = 0; j < 9; j++) {
                char cell = board[i][j];
                if(cell == '.') continue;
                int square = (i / 3) * 3 + (j / 3);

                if(rows[i].Contains(cell) || cols[j].Contains(cell) || squares[square].Contains(cell)) return false;
                
                rows[i].Add(cell);
                cols[j].Add(cell);
                squares[square].Add(cell);
            }   
        }
        return true;
    }
}
