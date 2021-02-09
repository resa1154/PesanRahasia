using System;
using System.Text.RegularExpressions;

namespace PesanRahasia
{
    class ProgramKata
    {


        static void Main(string[] args)
        {
            char[] arr = new char[5];
            Console.WriteLine("Masukkan Text: ");
            string inputstring = Console.ReadLine();

            if (Regex.IsMatch(inputstring, @"^[a-zA-Z]+$"))
            {
                arr = inputstring.ToCharArray();

                //display
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Inputan salah, harus berupa text a-z");
                Console.ReadLine();
            }

        }

        private static void pesan_rahasia(int newSize)
        {

            char[] arrChar = new char[100];
            int j, size;
            int posisi = size - newSize;
            //simpan huruf prtama
            char temp = arrChar[posisi];
            for (j = posisi + 1; j < size; j++)
                //geser hurup lain kekiri
                arrChar[j - 1] = arrChar[j];
            //meletakkan huruf prtama kekanan
            arrChar[j - 1] = temp;
        }
    }
}
