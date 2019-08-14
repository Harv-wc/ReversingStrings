using System;

namespace ReversingStrings
{
    class Program
    {
        //print the words of a string in reversing order; ie: "The Dog Jumped" => "Jumped Dog The".
        static void Main(string[] args)
        {
            //string myString = "The Dog Jumped";
            string myString = "Yo, lets try out a really long and GoOfY string to see if this actually works... lulzz";
            string myNewString = "";
            string tempString = "";
            Console.WriteLine(myString);
            for (int i = myString.Length-1; i >= 0; i--)
            {
                if(i==0)
                {
                    tempString += myString[i];
                    myNewString += Reverse(tempString);
                    tempString = "";
                }
                else if (Convert.ToString(myString[i]) != " ")
                {
                    tempString += myString[i];
                }
                else // mystring[i] == " "
                {
                    myNewString += Reverse(tempString)+" ";
                    tempString = "";
                }
            }
            Console.WriteLine(myNewString);
        }

        public static string Reverse(string str)
        {
            string newStr = "";
            for(int i = str.Length-1; i >= 0; i-- )
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
