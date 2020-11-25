using System;

namespace Array
{
    public class SortedRotatedArray{
/*
        public static void Main(){
            int[] arr={3,4,5,1,2};
            int n=arr.Length;
            int key=2;
            int index=Search(arr,0,n-1,key);

            if(index==-1) Console.Out.Write("Key not found");
            else Console.Out.Write($"Key found at {index}");
        }

        public static int Search(int[] arr, int low, int high, int key){
            if(low>high) return -1;

            int mid=(low+high)/2;

            if(arr[mid]==key) return mid;

            if(arr[low]<arr[mid]){ //check if first half is sorted
                if(arr[low]<=key && arr[mid]>key){ //check key is in the first half range
                    return Search(arr, low, mid-1,key);
                }
                else{
                    return Search(arr, mid+1,high,key);
                }
            }
            else{ // Then second half is sorted
                if(arr[mid]<key && arr[high]>=key){
                    return Search(arr,mid+1,high,key);
                }
                else{
                    return Search(arr,low,mid-1,key);
                }
            }
        }*/
    }
}