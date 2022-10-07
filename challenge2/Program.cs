using System;

namespace challenge2{
    class Program{
        public static void Main(string[] args){
            NumberAverage();
        }
        public static void NumberAverage(){
            try{
                // set Array size
                int userArr = 4;
                int[] userNum = new int[userArr];

                userNum = Populate(userArr, userNum);
                // add all the numbers then divide them by 4
                double results = ((userNum[0] + userNum[1] + userNum[2] + userNum[3]) / 4);
                // display results
                Console.WriteLine($"The Average of {String.Join(", ", userNum)} is: {results}");
            }
            catch(Exception ){
                Console.WriteLine("Something went wrong...");
            }

        }
        static int[] Populate(int userArr, int[] userNum) {
                //  loop through array size until user fills it
            for ( int i = 0; i < userArr; i++){
                 
                Console.WriteLine($"Please enter a number between 2-10: {i + 1}/{userArr}");
                int newNum = Convert.ToInt32(Console.ReadLine());
                userNum[i] = newNum;
                // prevent the user from entering negative numbers
                 if(userNum[i] < 0 ){
                Console.WriteLine("No Negative Numbers!!!");
                throw new Exception();
            }
            // prevent the user from entering numbers higher than 10
                if(userNum[i] > 10){
                    Console.WriteLine("Numbers is to Large!!!");
                    throw new Exception();
                }
                // user number can not be either 0 or 1
                if(userNum[i] == 0){
                    Console.WriteLine("Number is lower than 2");
                    throw new Exception();
                }
                if(userNum[i] == 1){
                    Console.WriteLine("Number is lower than 2");
                    throw new Exception();
                }
            }
            
           
            return userNum;
        }
    }
}
