using System;

namespace Tree{
    public class SortedArrayToBinarySearchTree{
        /*public static void Main(){
            int[] sortedArray=new int[]{1,2,3,4,5,6};
            Node root=CreateBinarySearchTree(sortedArray,0,sortedArray.Length-1);

            InOrderTraversal(root);
        }

        public static Node CreateBinarySearchTree(int[] array, int start, int end){
            if(start>end) return null;

            int mid;
            if(end==start) mid=end;
            else mid=start+((end-start)/2);

            Node node=new Node();
            node.Value=array[mid];

            node.LeftChild=CreateBinarySearchTree(array,start,mid-1);
            node.RightChild=CreateBinarySearchTree(array,mid+1,end);

            return node;
        }

        */
    }

    public class Node{
        public int Value{get;set;}
        public Node LeftChild{get;set;}
        public Node RightChild{get;set;}

        public static void InOrderTraversal(Node root){
            if(root == null) return;

            InOrderTraversal(root.LeftChild);
            Console.Out.Write($"{root.Value} ");
            InOrderTraversal(root.RightChild);
        }
    }
}