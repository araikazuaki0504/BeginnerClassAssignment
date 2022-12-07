using System;
using System.Collections.Generic;

namespace _3_9
{
    class Program
    {
        static List<int> SortData = new List<int>();

        static void Main(string[] args)
        {
            int[] Data = { 2, 4, 7, 8, 3, 4, 5, 1, 2, 3, 7, 3, 6, 7, 2, 6, 3, 8, 3, 1, 7, 1, 9, 3, 5, 3, 6, 7, 3, 9 };

            int[] Ans = MergeSort(Data);

            Console.WriteLine(Ans[Data.Length - 1].ToString());
        }

        static int[] MergeSort(int[] Data)
        {
            int[] Default = { 1,1,1,1}; 

            if (Data.Length == 1)
            {
                int[] ReturnData = new int[1];

                ReturnData[0] = Data[0];
                return ReturnData;
            }
            else if (Data.Length == 2)
            {
                if (Data[0] > Data[1])
                {
                    int[] ReturnData = new int[2];

                    ReturnData[0] = Data[1];
                    ReturnData[1] = Data[0];

                    return ReturnData;
                }
                else
                {
                    int[] ReturnData = new int[2];

                    ReturnData[0] = Data[0];
                    ReturnData[1] = Data[1];

                    return ReturnData;
                }
            }
            else
            {
                if (Data.Length % 2 == 0)
                {
                    //はじめのmerge
                    int[] firstData = DivData(0, (Data.Length / 2) - 1, Data);
                    int[] FirstMerge = MergeSort(firstData);

                    //2つめのmerge
                    int[] nextData = DivData((Data.Length / 2), Data.Length, Data);
                    int[] SecondMerge = MergeSort(nextData);

                    int[] ReturnData = new int[Data.Length];

                    int FirstCounter = 0;
                    int SecondCounter = Data.Length / 2;

                    int DATA_LENGTH = Data.Length / 2 - 1;

                    for (int i = 0; i < Data.Length; i++)
                    {
                        
                        if (FirstCounter + SecondCounter == Data.Length - 2)
                        {
                            return ReturnData;
                        }
                        else if (FirstCounter == DATA_LENGTH)
                        {
                            ReturnData[i] = SecondMerge[SecondCounter];
                            SecondCounter += 1;
                        }
                        else if (SecondCounter == DATA_LENGTH)
                        {
                            ReturnData[i] = FirstMerge[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (Data[FirstCounter] <= Data[SecondCounter])
                        {
                            ReturnData[i] = Data[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (Data[FirstCounter] > Data[SecondCounter])
                        {
                            ReturnData[i] = Data[SecondCounter];
                            SecondCounter += 1;
                        }

                    }
                    return ReturnData;
                }
                else
                {
                    //はじめのmerge
                    int[] firstData = DivData(0, (Data.Length / 2) + 1, Data);
                    int[] FirstMerge = MergeSort(firstData);

                    //2つめのmerge
                    int[] nextData = DivData((Data.Length / 2) + 1, Data.Length, Data);
                    int[] SecondMerge = MergeSort(nextData);

                    int[] ReturnData = new int[Data.Length];

                    int FirstCounter = 0;
                    int SecondCounter = Data.Length / 2;

                    int DATA_LENGTH = Data.Length / 2;

                    for (int i = 0; i < Data.Length; i++)
                    {
                        if (FirstCounter + SecondCounter == DATA_LENGTH - 1)
                        {
                            return ReturnData;
                        }
                        else if (FirstCounter == DATA_LENGTH + 1)
                        {
                            ReturnData[i] = SecondMerge[SecondCounter];
                            SecondCounter += 1;
                        }
                        else if (SecondCounter == DATA_LENGTH)
                        {
                            ReturnData[i] = FirstMerge[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (Data[FirstCounter] <= Data[SecondCounter])
                        {
                            ReturnData[i] = Data[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (Data[FirstCounter] > Data[SecondCounter])
                        {
                            ReturnData[i] = Data[SecondCounter];
                            SecondCounter += 1;
                        }
                        return ReturnData;
                    }
                }
                return Default;
            }

            static int[] DivData(int Init, int Fin, int[] Data)
            {
                int[] SetData = new int[Fin - Init];

                for (int i = 0; i < Fin - Init; i++)
                {
                    SetData[i] = Data[i + Init];
                }

                return SetData;
            }
        }
    }
}
