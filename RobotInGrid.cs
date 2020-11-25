using System;
using System.Collections.Generic;
using System.Drawing;

namespace DynamicProgramming{
    public class RobotInGrid{
        public static void Main(){
            bool[][] grid=new bool[3][]{
                new bool[]{true,true,false},
                new bool[]{true,false,true},
                new bool[]{true,true,true}
            };
            LinkedList<Point> route=new LinkedList<Point>();
            route.AddLast(new Point(0,0));

            List<Point> visited=new List<Point>();
            Point end=new Point(grid.Length-1,grid[grid.Length-1].Length-1);

            bool found = FindPath(grid,route,visited,new Point(0,0),end);

            if(found){
                foreach(Point p in route){
                    Console.Out.Write($"[{p.X}{p.Y}] ");
                }
            }
            else Console.Out.Write("Path do not exist");

        }

        public static bool FindPath(bool[][] grid, LinkedList<Point> route, List<Point> visited, Point node, Point end){
            
            visited.Add(node);

            if(node == end) return true;

            Point rightNode=new Point(node.X,node.Y+1);
            if(rightNode.Y < grid[0].Length && !visited.Contains(rightNode) 
                && grid[rightNode.X][rightNode.Y]==true){
                    route.AddLast(rightNode);
                    if(!FindPath(grid,route,visited,rightNode,end)){
                        route.RemoveLast();
                    }
                    else return true;
                }
            Point downNode=new Point(node.X+1,node.Y);
            if(downNode.X < grid.Length && !visited.Contains(downNode) 
                && grid[downNode.X][downNode.Y]==true){
                    route.AddLast(downNode);
                    if(!FindPath(grid,route,visited,downNode,end)){
                        route.RemoveLast();
                        return false;
                    }
                    else return true;
                }

            return false;
        }
    }
}