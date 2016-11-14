using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Dijkstra
{
    public class Program
    {
        private int BigSize = 500000;
        private int[,] map=new int[,]{{BigSize,3,2,BigSize,BigSize},
                                {BigSize,BigSize,2,4,BigSize},
                                {BigSize,BigSize,BigSize,1,3},
                                {BigSize,BigSize,BigSize,BigSize,4},
                                {BigSize,BigSize,BigSize,BigSize,BigSize}};
        private int[] dist=new int[]{BigSize,BigSize,BigSize,BigSize,BigSize};
        private int[] prev=new int[]{-1,-1,-1,-1,-1};
        public static void Main(string[] args)
        {
            serch(0,3);
        }
        private static void serch(int start, int end){
            if(start>5 || end>5)
                Console.WriteLine("error");
            dist[start]=0; // start initialization
            for(int i=0; i<5; i++){
                for(int j=0; j<5; j++){
                    if(map[i,j]!=BigSize){
                        if(dist[j]==BigSize){
                            dist[j]=dist[i]+map[i,j];
                            prev[j]=i;
                        }
                        else if(dist[j] > dist[i]+map[i,j]){
                            dist[j]=dist[i]+map[i,j];
                            prev[j]=i;
                        }
                    }
                }
            }
            Console.WriteLine("length:"+dist[end]);
            trck(start,end);
        }
        private static int trck(int start,int tmp){
            if(tmp==start){
                Console.Write(start);
            }else{
                Console.Write(tmp+"->");
                return trck(start,prev[tmp]);
            }
            return 0;
                
        }
    }
}