using System;
using System.IO;
using System.Collections.Generic;

namespace Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read all data from 'log.txt'.
            // Each line represents a log message from a web server
            // Write a function that returns an array with the unique IP adresses.
            // Write a function that returns the GET / POST request ratio.

            string pathLog = @"C:\Users\garayt\greenfox\janos777\week-03\day-02\Logs\log.txt";
            string pathIncorrect = @"..\Logs\log.txt";

            IPAddresses(pathLog);
            //GetPostRatio(pathLog);




            Console.ReadLine();
        }

        static void IPAddresses(string path)
        {
            string[] readLog = File.ReadAllLines(path);
            string[] ip = new string[readLog.Length];


            /*
            for (int i = 0; i < readLog.Length; i++)
            {
                string stringLine = readLog[i];
                readLog[i] = stringline
                ip[i] = stringLine[i];
            }
            */



            foreach (string s in readLog)
            {
                string[] stringLine = new string[] { s };
                stringLine[5].
                //Console.WriteLine(stringLine[0]);
            }

            



            

        }

        /*
        static double GetPostRatio(string path)
        {


        }
        */
    }
}