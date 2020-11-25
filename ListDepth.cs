using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tree{
    public class ListDepth{
      /*  public static void Main(){
            Node root=GetSampleTree();

            List<LinkedList<Node>> result=new List<LinkedList<Node>>();
            LinkedList<Node> list=new LinkedList<Node>();

            list.AddLast(root);
            while(true){
                LinkedList<Node> newList=new LinkedList<Node>();
                foreach(Node n in list){
                    if(n.LeftChild != null) newList.AddLast(n.LeftChild);
                    if(n.RightChild != null) newList.AddLast(n.RightChild);
                }
                if(newList.Any()){
                    result.Add(newList);
                    list=newList;
                }
                else break;
            }

            foreach(var ll in result){
                foreach(Node x in ll){
                    Console.Out.Write($"{x.Value} ");
                }
                Console.Out.WriteLine(" ");
            }
        }

        public static Node GetSampleTree(){
            var node=new Node();
            node.Value=2;

            return node;
        }*/
    }
}