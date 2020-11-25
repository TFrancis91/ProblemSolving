using System;
using System.Text;

namespace Sorting{
    public class StringSort{
       /* public static void Main(){
            string s="Hello";
            s=s.ToLower();
            StringBuilder stringBuilder=new StringBuilder(s);
            QuickSort(stringBuilder, 0, s.Length-1);
            Console.Out.Write(stringBuilder);
        }

        public static void QuickSort(StringBuilder s, int low, int high){
            if(low>high) return;

            int pi=Partition(s,low,high);
            QuickSort(s,low,pi-1);
            QuickSort(s,pi+1,high);
        }

        public static int Partition(StringBuilder s, int low, int high){
            int pi=low;
            int pivot=high;

            for(int i=low;i<high;i++){
                if(s[i].CompareTo(s[pivot])<0){
                    Swap(s,i,pi);
                    pi++;
                }
            }
            Swap(s,pi,pivot);
            return pi;
        }

        public static void Swap(StringBuilder s, int m, int n){
            if(m!=n){
                char temp=s[m];
                s[m]=s[n];
                s[n]=temp;
            }
        }*/
    }

    
}