using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameofLife
{
    public class GameOfLifeController
    {
        public int[,] gamearray = new int[10, 10];
        //first rows then columns 
        public GameOfLifeController()
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(i==1 && j == 2 || i == 2 & j == 1|| i == 2 & j == 3 || i == 3 & j == 2)
                    {
                        gamearray[i, j] = 1;
                    }
                    else
                    {
                        gamearray[i, j] = 0;
                    }

                }
            }
            var rand = new Random();
            int irand = rand.Next(9);
            int jrand = rand.Next(9);
            gamearray[0, 0] = 1;
            gamearray[0, 1] = 1;
            gamearray[1, 0] = 1;
            gamearray[irand, jrand] = 1;

        }
        
        public void newlifecicle()
        {
            int[,] localarray = gamearray;
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (gamearray[i, j] == 1)
                    {
                        localarray[i, j] = 0;
                        if (i - 1 > 0)
                            {
                                if(gamearray[i-1, j] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                            }
                        if (j - 1 > 0)
                        {
                            if (gamearray[i, j-1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (i - 1 > 0 && j-1>0)
                        {
                            if (gamearray[i - 1, j-1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }

                        if (i + 1 < 10)
                        {
                            if (gamearray[i + 1, j] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (j + 1 < 10)
                        {
                            if (gamearray[i, j + 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (i + 1 < 10 && j + 1 < 10)
                        {
                            if (gamearray[i + 1, j + 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }

                        if (i - 1 > 0 && j + 1 <10)
                        {
                            if (gamearray[i - 1, j + 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }
                        }
                        if (i + 1 <10 && j - 1 >0)
                        {
                            if (gamearray[i + 1, j - 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }
                        }

                    }
                    else
                    {
                        if (i - 1 > 0)
                        {
                            if (gamearray[i - 1, j] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (j - 1 > 0)
                        {
                            if (gamearray[i, j - 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (i - 1 > 0 && j - 1 > 0)
                        {
                            if (gamearray[i - 1, j - 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }

                        if (i + 1 < 10)
                        {
                            if (gamearray[i + 1, j] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (j + 1 < 10)
                        {
                            if (gamearray[i, j + 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }
                        if (i + 1 < 10 && j + 1 < 10)
                        {
                            if (gamearray[i + 1, j + 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }

                        }

                        if (i - 1 > 0 && j + 1 < 10)
                        {
                            if (gamearray[i - 1, j + 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }
                        }
                        if (i + 1 < 10 && j - 1 > 0)
                        {
                            if (gamearray[i + 1, j - 1] == 1)
                            {
                                localarray[i, j] += 1;
                            }
                        }                      
                    }
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (gamearray[i, j] == 1)
                    {
                        if (localarray[i, j] == 3 || localarray[i, j] == 2)
                        {
                            localarray[i, j] = 1;
                        }
                        else 
                        {
                            localarray[i, j] = 0;
                        }
                    }
                    else
                    {
                        if (localarray[i, j] == 3)
                        {
                            localarray[i, j] = 1;
                        }
                        else
                        {
                            localarray[i, j] = 0;
                        }
                    }

                }
            }
                    gamearray = localarray;
        }
    }
}
