using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Damka
{
    class DamkaProp
    {
        public static int[,] DrawDamka(int[,] S, bool isTurnBlue, int x1, int y1, int x2, int y2, bool isEaten)
        {
            int i, j, X = 0, x3 = -1, y3 = -1;

            if (x2 < x1)
                X = 1;
            if (x2 > x1)
                X = -1;

            if (isTurnBlue)
            {
                y3 = y2 + 1;
                x3 = x2 + X;
            }
            else
            {
                y3 = y2 - 1;
                x3 = x2 + X;
            }
            if (isEaten)
            {
                for (i = 1; i <= 9; i++)
                {
                    for (j = 1; j <= 9; j++)
                    {
                        if (j == x1 && i == y1 || j == x3 && i == y3)
                        {
                            S[i, j] = 0;
                        }
                        if (j == x2 && i == y2)
                        {
                            if (isTurnBlue)
                            {
                                S[i, j] = 2;
                            }
                            else
                            {
                                S[i, j] = 1;
                            }
                        }
                    }
                }
            }
            else
            {
                for (i = 1; i <= 9; i++)
                {
                    for (j = 1; j <= 9; j++)
                    {
                        if (j == x1 && i == y1)
                        {
                            S[i, j] = 0;
                        }
                        if (j == x2 && i == y2)
                        {
                            if (isTurnBlue)
                            {
                                S[i, j] = 2;
                            }
                            else
                            {
                                S[i, j] = 1;
                            }
                        }
                    }
                }
            }
            return S;
        }
        public static bool IsEat(int[,] S, int x1, int y1, int x2, int y2, bool isBlue)
        {
            int X = 0;

            if (x2 < x1)
                X = -1;
            if (x2 > x1)
                X = 1;

            if (isBlue)
            {

                if (S[y1 - 1, x1 + X] == 1)
                    return true;
            }
            else
            {
                if (S[y1 + 1, x1 + X] == 2)
                    return true;
            }
            return false;
        }
        public static bool ErrorCheck(int[,] Soilders, int x1, int y1, int x2, int y2, bool isBlue, bool isEat, bool isAble)
        {
            bool Retrun = false;

            if (isBlue)
            {
                if (Soilders[y1, x1] != 2) 
                    Retrun = true;
                if (Soilders[y2, x2] != 0)
                    Retrun = true;
                if ((x1 + y1) % 2 != 0 || (x2 + y2) % 2 != 0)
                    Retrun = true;
                if (x2 == x1 || y2 >= y1 && !isAble && Soilders[x1,y1] != 4)
                    Retrun = true;
                if (!isEat && y1 - 1 != y2)
                    Retrun = true;

            }
            else
            {
                if (Soilders[y1, x1] != 1) 
                    Retrun = true;
                if (Soilders[y2, x2] != 0)
                    Retrun = true;
                if ((x1 + y1) % 2 != 0 || (x2 + y2) % 2 != 0 && Soilders[x1, y1] != 3)// רק במשבצות שצריך
                    Retrun = true; 
                if (x2 == x1 || y2 <= y1)
                    Retrun = true;
                if (!isEat && y1 + 1 != y2)
                    Retrun = true;
            }
            return Retrun;
        }

        public static bool isAbleEat(int[,] S, int x2, int y2, bool isBlue)
        {
            bool isAble = false;



            if (isBlue)
            {
                if (S[y2 - 1, x2 + 1] == 1 && S[y2 - 2, x2 + 2] == 0 && x2 != 7 && y2 != 2 || S[y2 - 1, x2 - 1] == 1 && S[y2 - 2, x2 - 2] == 0 && x2 != 2 && y2 != 2)//Normal
                    isAble = true;
                if (S[y2 + 1, x2 + 1] == 3 && S[y2 + 2, x2 + 2] == 0 && x2 != 7 && y2 != 2 || S[y2 + 1, x2 - 1] == 3 && S[y2 + 2, x2 - 2] == 0 && x2 != 2 && y2 != 2)//King
                    isAble = true;

            }
            else
            {
                if (S[y2 - 1, x2 + 1] == 2 && S[y2 - 2, x2 + 2] == 0 && x2 != 7 && y2 != 7 || S[y2 - 1, x2 - 1] == 2 && S[y2 - 2, x2 - 2] == 0 && x2 != 2 && y2 != 7)//Normal
                    isAble = true;
                if (S[y2 + 1, x2 + 1] == 4 && S[y2 + 2, x2 + 2] == 0 && x2 != 7 && y2 != 7 || S[y2 + 1, x2 - 1] == 4 && S[y2 + 2, x2 - 2] == 0 && x2 != 2 && y2 != 7)//King
                    isAble = true;
            }


            return isAble;
        }
        public static void MakeKings(ref int[,] N)
        {
            int i;
            for (i = 1; i <= 9; i++)
            {
                if (N[1, i] == 2)
                    N[1, i] = 4;
                if (N[8, i] == 1)
                    N[8, i] = 3;
            }


        }

    }
}


