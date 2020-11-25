using System;

namespace DynamicProgramming{
    public class TripleStep{
       /* public static void Main(){
            int steps=5;
            int[] memo=new int[steps+1];
            for(int i=0;i<steps+1;i++){
                memo[i]=-1;
            }
            int count=CountWays(steps,memo);

            Console.Out.Write($"Possible combinations = {count}");
        }

        public static int CountWays(int steps, int[] memo){
            if(steps<0) return 0;
            if(steps==0) return 1;

            if(memo[steps]<0){
                return memo[steps]=CountWays(steps-1,memo)+
                CountWays(steps-2,memo)+
                CountWays(steps-3,memo);
            }
            else return memo[steps];

        }*/
    }
}