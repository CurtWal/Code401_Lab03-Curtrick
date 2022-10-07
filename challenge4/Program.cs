using System;

namespace challenge4{
    class Program{
        public static void Main(string[] args) {
            int userArr = 6;
            int[] userNum = new int[userArr];

            userNum = Populate(userArr, userNum);

            // start the number count at 1
            int count = 1, tempCount;
            int frequentNumber = userNum[0];
            int tempNumber = 0;
            for (int i = 0; i < (userNum.Length - 1); i++)
            {
                tempNumber = userNum[i];
                tempCount = 0;
                for (int j = 0; j < userNum.Length ; j++)
                {
                    if (tempNumber == userNum[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.",frequentNumber,count);            
            Console.ReadKey();
        }
          static int[] Populate(int userArr, int[] userNum) {
            for (int i = 0; i < userArr; i++){
                Console.WriteLine($"Please enter  6 numbers: {i + 1}/{userArr}");
                int newNum = Convert.ToInt32(Console.ReadLine());
                userNum[i] = newNum; 
            }
            return userNum;  
        }
     }
    }
