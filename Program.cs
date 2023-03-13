using System;
using System.Collections.Generic;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {    

            //out parametresi
            string k="1234";
            int.TryParse(k,out int sonuc);
            Console.WriteLine("sonuc:"+sonuc*2);


            //overload
            Metodlar metods=new Metodlar();

            metods.EkranaYaz("Elma","Armut");
            metods.EkranaYaz(123,567);

            metods.VeriOutput(10,out int v);
            Console.WriteLine(v);

        }
    }

    class Metodlar
    {
        public int VeriOutput(int veri,out int sonuc){
            sonuc=veri*2+5;
            return sonuc;
        }

        public void EkranaYaz(string veri){
            Console.WriteLine(veri);
        }

        public void EkranaYaz(int veri){
             Console.WriteLine(veri);
        }

        public void EkranaYaz(string veri1,string veri2){
             Console.WriteLine(veri1+" "+veri2);
        }

        public void EkranaYaz(int veri1,int veri2){
             Console.WriteLine(veri1+" "+veri2);
        }

    }
}
