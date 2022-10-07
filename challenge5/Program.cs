using System;

namespace challenge5{
    class Program{
        public static void Main(string[] args) {
            int userArr = 6;
            int[]userNum = new int[userArr];

            userNum = Populate(userArr, userNum);
            // searches for the highest value
            int highest = userNum.Max();
            Console.WriteLine($"The Numbers you entered were: {String.Join(", ", userNum)} and the highest number was: {highest}");
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
