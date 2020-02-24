using System;

namespace Problems
{
    public class Program
    {

       public static string Prefix(string input){

           int length = input.Length;

             int i = 0, myWord = 0;
             string [] splitString = input.Split(); 

            /* loop till end of string */
              while (i < splitString.Length) {
                   if(string.IsNullOrWhiteSpace(splitString[i])){
                      i++;
                      continue; 
                   }
                   else
                   {
                       i++;
                       myWord++;
                   }
              }
               
            string value = length.ToString() +"," + myWord.ToString() + ":" + input;
            //Console.WriteLine(length.ToString(), ",", countWord.ToString(), input);
            return value;
    }
    static void Main(string[] args)
    {
            string x = Prefix("I want this");
            Console.WriteLine(x);
    }
      

} 
}  




        
