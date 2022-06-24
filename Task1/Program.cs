namespace Task1;

static class Program { // sudoku validation

    public static bool SudokuValidation(int[,] arr) {
        if (arr.GetLength(0) != arr.GetLength(1)) {
            return false;
        }

        if(Math.Sqrt(arr.GetLength(0)) % 1 != 0) {
            return false;
        }

        int n = arr.GetLength(0);
        int sqrt = (int)Math.Sqrt(n);
        int[,] temp = new int[n, n];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                temp[i, j] = arr[i, j];
            }
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                if (temp[i, j] != 0) {
                    int num = temp[i, j];
                    temp[i, j] = 0;
                    if (CheckRow(temp, num, i) && CheckColumn(temp, num, j) && CheckSquare(temp, num, i, j)) {
                        temp[i, j] = num;
                    } else {
                        return false;
                    }
                }
            }
        }
        return true;
        
    }

    private static bool CheckSquare(int[,] temp, int num, int i, int j) {
        int sqrt = (int)Math.Sqrt(temp.GetLength(0));
        int k = ((int) (i / sqrt)) * sqrt;
        int l = ((int) (j / sqrt)) * sqrt;
        int kMax = k + sqrt;
        int lMax = l + sqrt;
        for (; k < kMax; k++) {
            for (; l < lMax; l++) {
                if (temp[k, l] == num) {
                    return false;
                }
            }
        }
        return true;
    }

    private static bool CheckColumn(int[,] temp, int num, int i) {
        for (int j = 0; j < temp.GetLength(0); j++) {
            if (temp[j, i] == num) {
                return false;
            }
        }
        return true;
    }

    private static bool CheckRow(int[,] temp, int num, int i) {
        for (int j = 0; j < temp.GetLength(0); j++) {
            if (temp[i, j] == num) {
                return false;
            }
        }
        return true;
    }

    static void Main() {
        int[,] arr = new int[9, 9] {
            { 7, 8, 4,  1, 5, 9,  3, 2, 6 },
            { 5, 3, 9,  6, 7, 2,  8, 4, 1 },
            { 6, 1, 2,  4, 3, 8,  7, 5, 9 },
            
            { 9, 2, 8,  7, 1, 5,  4, 6, 3 },
            { 3, 5, 7,  8, 4, 6,  1, 9, 2 },
            { 4, 6, 1,  9, 2, 3,  5, 8, 7 },
            
            { 8, 7, 6,  3, 9, 4,  2, 1, 5 },
            { 2, 4, 3,  5, 6, 1,  9, 7, 8 },
            { 1, 9, 5,  2, 8, 7,  6, 3, 4 }
        };
        Console.WriteLine(SudokuValidation(arr));

    }
}