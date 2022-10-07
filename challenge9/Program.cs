using System;

namespace challenge9{
    class Program{
        public static void Main(string[] args){
            string []userSen = new String[7];
            for(int i = 0; i < userSen.Length; i++){
            // string[] userSenArr = new string[userSen];
            userSen[i] = Console.ReadLine();
            
            }
            Console.WriteLine($"{userSen[0]}: {userSen[0].Length} {userSen[1]}: {userSen[1].Length} {userSen[2]}: {userSen[2].Length} {userSen[3]}: {userSen[3].Length} {userSen[4]}: {userSen[4].Length} {userSen[5]}: {userSen[5].Length} {userSen[6]}: {userSen[6].Length}");
        }
    }
}