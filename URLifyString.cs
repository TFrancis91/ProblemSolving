using System;
using System.Text;

namespace Strings{
    public class URLifyString{
       /* public static void Main(){
            string s="Mr John Smith    ";
            int length=13;

            var result=URLify(s,length);

            Console.Out.Write(result);
        }

        public static string URLify(string s, int length){
            if(s==null || s==String.Empty) return String.Empty;

            StringBuilder stringBuilder=new StringBuilder(s);
            int lastIndex=length-1;

            int pointer=s.Length-1;
            for(int i=lastIndex;i>=0;i--){
                if(stringBuilder[i]!=' ') stringBuilder[pointer]=stringBuilder[i];
                else{
                    stringBuilder[pointer]='0';
                    pointer--;
                    stringBuilder[pointer]='2';
                    pointer--;
                    stringBuilder[pointer]='%';
                }
                pointer--;
            }

            return stringBuilder.ToString();
        }*/
    }
}