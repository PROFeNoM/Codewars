using System;

namespace Scytale
{
    public class Scytale
    {
        public static string Decode(string message, int col)
        {
            int row = (int)Math.Ceiling((double)message.Length / col);
            char[,] table = new char[row, col];
            int index = 0;
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                {    
                    table[i, j] = index < message.Length ? message[index] : ' ';
                    index++;
                }
                
            string decoded = "";
            for (int j = 0; j < col; j++)
                for (int i = 0; i < row; i++)
                    decoded += table[i, j];
            return decoded.Trim();
        }

        public static string Encode(string message, int col)
        {
            int row = (int)Math.Ceiling((double)message.Length / col);
            char[,] table = new char[row, col];
            int index = 0;
            for (int j = 0; j < col; j++)
                for (int i = 0; i < row; i++)
                {    
                    table[i, j] = index < message.Length ? message[index] : ' ';
                    index++;
                }

            string encoded = "";
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    encoded += table[i, j];
            return encoded.Trim();
        }
    }
}
