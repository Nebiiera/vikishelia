using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monacemebi = new string[6];
            wigni w = new wigni();
            monacemebi[0] = w.Name();
            monacemebi[1] = w.Date().ToString();
            monacemebi[2] = w.Author();
            monacemebi[3] = w.PageNum();
            monacemebi[4] = w.Gamomcemloba();
           
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(monacemebi[i]);
            }


            Console.ReadKey();



        }


    }

     public abstract class Gamocema
    {
        string[] gamocemebi = {"gamocema1","gamocema2","gamocema3","gamocema4","gamocema5"};
        public void print() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(gamocemebi[i]);
            }
        }

    }

    public class wigni
    {
        string name = "utavo mxedari";
        string author = "main ridi";
        int date = 1923;
        string gamomcemloba = "libra";
        string pageNum = "255";
        public int Date()
        {
            return this.date;
        }
        public string Name()
        {
            return this.name;
        }
        public string Author()
        {
            return this.author;
        }
        public string Gamomcemloba()
        {
            return this.gamomcemloba;
        }
        public string PageNum()
        {
            return this.pageNum;
        }

      
    }

    public class statia : Gamocema
    {
        string name="statia1";
        string author="avtori1";
        int date = 2002;
        string jurnalisDasaxeleba="jurnali1";
        string pageNum = "10";
        string[] s = new string[5];

        public String[] ret() {
            s[0] = name;
            s[1] = author;
            s[2] = date.ToString();
            s[3] = jurnalisDasaxeleba;
            s[4] = pageNum;
            return this.s;
        }
    }

    public class elResursi : Gamocema
    {
        string name="res1";
        string author= "avtori el resursis";
        string bmuli= "https://www.facebook.com/";
        string anotacia= "Lorem ipsum dolor sit amet, consectetur adipiscing elit\n" +
            ", sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\n" +
            " Ut enim ad minim veniam, quis nostrud exercitation ullamco ";

        string[] s = new string[4];

        public String[] ret()
        {
            s[0] = name;
            s[1] = author;
            s[2] = bmuli.ToString();
            s[3] = anotacia;
            return this.s;
        }



    }




}
