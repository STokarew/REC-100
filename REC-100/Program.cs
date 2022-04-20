using System;

namespace REC_100
{
    public interface IResponce<T>
    {
        int StatusCode { get; set; }
        T Data { get; set; }
        int Ok();
        int BadResponce();
    }
    class MyClass: IResponce<string>
    {
   public int StatusCode { get; set; }
   public  string Data { get; set; }
        public int Ok()
        {
            int a = 5;
            return a;
        }
       public int BadResponce()
        {
            int a = 2;
            return a;
        }
        public MyClass()
        {
            StatusCode = 500;
            Data = "Содержание вопроса";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new();
            var ok = mc.Ok();
            var br = mc.BadResponce();
            var data = mc.Data;
            var sc = mc.StatusCode;
            Console.WriteLine($"{data}, {sc}, {ok}, {br}");
            Console.ReadKey();
        }
    }
}
