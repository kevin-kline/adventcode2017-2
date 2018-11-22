using System;
using System.Collections.Generic;
using System.IO;

namespace adventcode2017_2
{
    public class Program
    {
        const string FILEPATH = "./../../../resources/checkSumInput.txt";
        

        public static List<String> getStringListFromFile(string filepath)
        {
            StreamReader sr = null;
            List<String> stringList = new List<String>();
            try
            {
                sr = new StreamReader(filepath);
                while (!sr.EndOfStream)
                {
                    stringList.Add(sr.ReadLine());
                }
            } catch(Exception e)
            {
                Console.WriteLine("read error: " + e.Message);
            }    
            
            if (sr != null)
            {
                sr.Close();
            }
            return stringList;

        }

        public static int getCheckSumFromStringList(List<String> stringList)
        {
            int checkSum = 0;

            //step 1: loop through string list, which contains each line from the txt file.
            //step 2: split each line into individual elements in an array of strings.
            //step 3: convert the array of strings into an array of integers.
            //step 4: loop through the array of integers to find the smallest value and the largest value.
            //step 5: subtract the smallest value from the largest value and add it to the checksum.

            //step 1
            foreach (string s in stringList)
            {
                //step 2
                string[] sArray = s.Split(null);

                //step 3
                int[] iArray = new int[sArray.Length];
                
                for(int i = 0; i < iArray.Length; i++)
                {
                    iArray[i] = Convert.ToInt32(sArray[i]);

                }
                //step 4
                int largestInLine = 0;
                int smallestInLine = 0;
                for (int i = 0; i < iArray.Length; i++)
                {
                    //first element assigned to both
                    if(i == 0)
                    {
                        smallestInLine = iArray[i];
                        largestInLine = iArray[i];
                    } else
                    {
                        if (iArray[i] > largestInLine)
                        {
                            largestInLine = iArray[i];

                        }
                        if (iArray[i] < smallestInLine)
                        {
                            smallestInLine = iArray[i];
                        }
                    }
                   
                    
                }
                //step 5
                checkSum += largestInLine - smallestInLine;

            }

            return checkSum;
        }

        static void Main(string[] args)
        {
          
            int checkSum = 0;

            List<String> stringList = getStringListFromFile(FILEPATH);

            checkSum = getCheckSumFromStringList(stringList);

            Console.WriteLine("Checksum value: " + checkSum);

            Console.ReadLine();
        }
    }
}
