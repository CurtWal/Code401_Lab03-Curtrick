using System;

namespace challenge1{
    class Program{
        static void Main(string[] args) {
            Multiply();
        }
        public static void Multiply() {
            try{
                // set array size
            int userArr = 3;
            int[] userNum = new int[userArr];
            //  pass array size to Populate method
            userNum = Populate(userArr, userNum);
            double results = ((userNum[0] * userNum[1]) * userNum[2]);
            // display results
           Console.WriteLine($"The Product of: {String.Join(", ", userNum)} is: {results}");
            }
            catch(Exception ){
                //  return 0 if not all 3 numbers are input
                Console.WriteLine("0");
            }
        }
        static int[] Populate(int userArr, int[] userNum) {
            //  loop through until array is full
            for (int i = 0; i < userArr; i++ ){
                //  ask the user to enter 3 numbers
                Console.WriteLine($"Please enter 3 numbers to mutiply: {i + 1}/{userArr}");
                //  record the user input
                int newNum = Convert.ToInt32(Console.ReadLine());
                userNum[i] = newNum; 
            }
            return userNum;   
        } 
    }
}