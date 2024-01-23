using ConsoleApp1;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using static System.Console;
public class Program

{

    

    private static void Main(string[] args)
    {


        // create data in file
        // create_data();
        //  read data    "test.txt"

        read_data("test.txt");









    }
    public static void create_data( string path ) {
        // write in files
        string temp;
       
        using (StreamWriter myfile = new StreamWriter(path, true))
        {
            WriteLine("plz enter your name :");
            temp = ReadLine();
            temp = $"{temp},";

            myfile.Write(temp);
            WriteLine("plz enter your age :");
            temp = ReadLine();
            temp = $"{temp},";

            myfile.Write(temp);
            WriteLine("plz choices your Gender \'   M | F \' :");
            temp = ReadLine();
            temp = $"{temp},";

            myfile.Write(temp);
            WriteLine("plz enter your address :");
            temp = ReadLine();
            

            myfile.Write(temp);
            myfile.Write("\n");

        }


    }

    public static void read_data(string path)
    {
        string[] data = File.ReadAllLines(path);

        // store row in array 
        String[] info = new string[4];
        int count = 1;
        foreach (string line in data)
        {

            // Console.WriteLine(line);


            info = line.Split(",");

            display_personal_info(info,count);
            count++;

        }

    }

    public static void display_personal_info(string[] info, int count) {
        string[] temp= new string[]{ " employee's name is : " ," and age is : ",
            " and gender : ", " and address is : "

        };


        for (int i = 0; i <info.Length; i++)
        {
            if (i == 0)
            {
                Write($"{count}{temp[i]}{info[i]}  ");
            }
            else {
                Write($"{temp[i]}{info[i]}  ");
            }
           
        }
        WriteLine("");

    }
}



