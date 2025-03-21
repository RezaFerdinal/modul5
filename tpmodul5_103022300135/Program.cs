﻿using System;

namespace tpmodul5_103022300135
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }
    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {data}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            HaloGeneric halo = new HaloGeneric();
            string nama = "Reza";
            halo.SapaUser(nama);

            string nim = "103022300135";
            DataGeneric<string> data = new DataGeneric<string>(nim);
            data.PrintData();
        }
    }
}