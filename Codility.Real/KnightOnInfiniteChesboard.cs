using System;

namespace Codility.Real
{
    /// <summary>
    /// The knight is the piece in the game of chess that, in one turn, can move two
    /// squares horizontally and one square vertically or two squares vertically and one
    /// square horizontally.
    /// An infinite chessboard is given.All of its squares are empty except for the square
    /// with coordinates (0, 0), where a knight stands.
    /// 
    /// Write a function:
    ///     function solution(A, B);
    /// 
    /// that, given two numbers A and B, returns the minimum number of turns required
    /// for the knight to move from square(0, 0) to square(A, B). The function should
    /// return -1 if the knight cannot reach the given square.The function should return
    /// -2 if the required number of turns exceeds 100,000,000.
    /// For example, given A = 4 and B = 5 the function should return 3, because the
    /// knight requires three turns to move from square(0, 0) to square(4, 5):
    /// in the first turn the knight moves from square(0, 0) to square(2, 1);
    /// in the second turn the knight moves from square(2, 1) to square (3. 3);
    /// in the third turn the knight moves from square(3, 3) to square(4, 5).
    /// 
    /// Assume that:
    /// A and B are integers within the range [-100, 000, 000..100, 000, 000].
    /// 
    /// Complexity:
    /// expected worst-case time complexity is 0(1);
    /// expected worst-case space complexity is 0(1).
    /// Copyright 2009-2016 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or
    /// disclosure prohibited.
    /// </summary>
    public class KnightOnInfiniteChesboard
    {
        public static int Solution(int A, int B)
        {
            A = Math.Abs(A);
            B = Math.Abs(B);

            if (A / (decimal) B < 0.5M || A / B > 2 || (A + B) % 3 != 0)
                return -1;

            var moves = (A + B) / 3;
            return moves <= 100000000 ? moves : -2;
        }
    }
}
