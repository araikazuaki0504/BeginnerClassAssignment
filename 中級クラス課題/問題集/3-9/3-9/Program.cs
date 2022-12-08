using System;

namespace _3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Data = { 2, 4, 7, 8, 3, 4, 5, 1, 2, 3, 7, 3, 6, 7, 2, 6, 3, 8, 3, 1, 7, 1, 9, 3, 5, 3, 6, 7, 3, 9 };

            int[] Ans = MergeSort(Data);
            int LastIndex = Data.Length - 1;

            Console.WriteLine("最大値は、" + Ans[LastIndex].ToString() + "です。");
        }

        static int[] MergeSort(int[] Data)
        {
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
                    int[] firstData = DivData(0, Data.Length / 2, Data);
                    int[] FirstMerge = MergeSort(firstData);

                    //2つめのmerge
                    int[] nextData = DivData((Data.Length / 2), Data.Length, Data);
                    int[] SecondMerge = MergeSort(nextData);

                    int[] ReturnData = new int[FirstMerge.Length + SecondMerge.Length];

                    int FirstCounter = 0;
                    int SecondCounter = 0;

                    int FIRST_DATA_MAX_INDEX = FirstMerge.Length;
                    int SECOND_DATA_MAX_INDEX = SecondMerge.Length;
                    int LOOP_TIMES = FIRST_DATA_MAX_INDEX + SECOND_DATA_MAX_INDEX;

                    for (int i = 0; i < LOOP_TIMES; i++)
                    {

                        if (FirstCounter == FIRST_DATA_MAX_INDEX)
                        {
                            ReturnData[i] = SecondMerge[SecondCounter];
                            SecondCounter += 1;
                        }
                        else if (SecondCounter == SECOND_DATA_MAX_INDEX)
                        {
                            ReturnData[i] = FirstMerge[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (FirstMerge[FirstCounter] <= SecondMerge[SecondCounter])
                        {
                            ReturnData[i] = FirstMerge[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (FirstMerge[FirstCounter] > SecondMerge[SecondCounter])
                        {
                            ReturnData[i] = SecondMerge[SecondCounter];
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
                    int SecondCounter = 0;

                    int FIRST_DATA_MAX_INDEX = FirstMerge.Length;
                    int SECOND_DATA_MAX_INDEX = SecondMerge.Length;
                    int LOOP_TIMES = FIRST_DATA_MAX_INDEX + SECOND_DATA_MAX_INDEX;

                    for (int i = 0; i < LOOP_TIMES; i++)
                    {

                        if (FirstCounter == FIRST_DATA_MAX_INDEX)
                        {
                            ReturnData[i] = SecondMerge[SecondCounter];
                            SecondCounter += 1;
                        }
                        else if (SecondCounter == SECOND_DATA_MAX_INDEX)
                        {
                            ReturnData[i] = FirstMerge[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (FirstMerge[FirstCounter] <= SecondMerge[SecondCounter])
                        {
                            ReturnData[i] = FirstMerge[FirstCounter];
                            FirstCounter += 1;
                        }
                        else if (FirstMerge[FirstCounter] > SecondMerge[SecondCounter])
                        {
                            ReturnData[i] = SecondMerge[SecondCounter];
                            SecondCounter += 1;
                        }
                    }
                    return ReturnData;
                }
            }
         }

        static int[] DivData(int Init, int Fin, int[] Data)
        {
            int DataLength = Fin - Init;
            int[] SetData = new int[DataLength];

            for (int i = 0; i < DataLength; i++)
            {
                SetData[i] = Data[i + Init];
            }

            return SetData;
        }
    }
}
