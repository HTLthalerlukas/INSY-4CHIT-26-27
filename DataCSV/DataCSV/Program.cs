using System;
using System.IO;
using System.Text;

namespace RandomCsvGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Data.csv";
            int totalRows = 1000000;
            Random random = new Random();
            int stringLength = 10;
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8, bufferSize: 65536))
            {
                for (int i = 1; i <= totalRows; i++)
                {
                    char[] stringBuffer = new char[stringLength];
                    for (int j = 0; j < stringLength; j++)
                    {
                        stringBuffer[j] = chars[random.Next(chars.Length)];
                    }
                    string randomStr = new string(stringBuffer);
                    
                    int randomNumber = random.Next(1, 2147483647);
                    
                    writer.WriteLine($"{i};{randomStr};{randomStr};{randomNumber};{randomNumber}");
                }
            }
        }
    }
}