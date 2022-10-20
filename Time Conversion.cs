using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        int hour,min,sec;
        bool isAm = false;
        string rest = s.Substring(2,6);
        
        hour = (int)Char.GetNumericValue(s[0]) * 10 + (int)Char.GetNumericValue(s[1]) ;
        
        if(s[8]=='A')
            isAm = true;
        
        if(isAm){
            if (hour==12)
                return "00" + rest;
            else
                return "0" + hour + rest;
        }
        else{
            if (hour==12)
                return "12" + rest;
            else
                return (hour + 12) + rest;
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
