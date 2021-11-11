using System;

class Hello
{
    static void Main() {
        int[,] map = new int[,] {
            {0, 0, 0, 0, 0, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 1, 1},
            {0, 0, 0, 0, 0, 1, 1, 1},
            {1, 1, 1, 1, 1, 1, 1, 1},
        };

        for (int i = 0; i < map.GetLength(0); i++) {
            for (int j = 0; j < map.GetLength(1); j++) {
                Console.Write(map[i, j]);
            }
            Console.WriteLine();
        }
    }
}
