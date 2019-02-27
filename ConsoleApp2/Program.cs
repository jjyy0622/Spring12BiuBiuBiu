using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Spring12BiuBiuBiu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("您好，请输入您的全球唯一识别ID：");
            Console.ReadLine();
            Console.WriteLine("正在获取【苏拉威西三号转向发动机点火权限】授权。。。\n");
            ProgressBar progressBar1 = new ProgressBar(Console.CursorLeft, Console.CursorTop, 50, ProgressBarType.Multicolor);
            for (int Getadmit = 1; Getadmit <= 100; Getadmit++)
            {
                Thread.Sleep(50);
                progressBar1.Dispaly(Getadmit);
            }
            Thread.Sleep(100);
            Console.WriteLine("\n");
            Console.WriteLine("根据《流浪地球法》，您已获得授权。\n");
            Thread.Sleep(1000);
            Console.WriteLine("发动机启动时间较长！\n");
            Console.WriteLine("请在等候时阅读【李一一】工程师编写的《春节十二响操作手册》。\n");

            Thread.Sleep(1000);
            Console.WriteLine("硬件系统自检完成...\n");
            Thread.Sleep(1000);
            Console.WriteLine("撞针系统自检完成...\n");
            Thread.Sleep(1000);
            Console.WriteLine("行星转向发动机正在启动中！启动进度：\n");
            progressBar1 = new ProgressBar(Console.CursorLeft, Console.CursorTop, 50, ProgressBarType.Character);
            for (int test = 1; test <= 100; test++) {
                Thread.Sleep(50);
                progressBar1.Dispaly(test);
            }
            Console.WriteLine("\n");
            Thread.Sleep(1000);
            Console.WriteLine("行星转向发动机已启动");
            Console.WriteLine("\n");
            Thread.Sleep(1000);
            int i;
            for (i = 1; i <= 12; i++)
            {
                fire();
                Thread.Sleep(50);
                Rest();
                Thread.Sleep(50);
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();//必须
            int a; a = 12;
            Console.WriteLine("\n");
            while (a >= 1)
            {
                
                Console.WriteLine("                        Biu!!!\n");
                a -= 1;
                Thread.Sleep(100);
            }
            int j = 12;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("                        \\ ^^ /\n");

            while (j >= 1)
            {
                Console.WriteLine("                        | ^^ |\n");
                j -= 1;
                Thread.Sleep(100);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            //行星发动机形状
            Console.WriteLine("                        /----\\");
            Console.WriteLine("                       / \\  / \\ ");
            Thread.Sleep(100);
            Console.WriteLine("                     | -------- | ");
            Thread.Sleep(100);
            Console.WriteLine("                  /| ------------ |\\ ");
            Thread.Sleep(100);
            Console.WriteLine("                  __________________");
            Thread.Sleep(100);
            Thread.Sleep(1000);
            Console.ReadKey();
        }
        static void fire()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();//必须
            Console.WriteLine("Biu~");
        }
        static void Rest()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();//必须
            Console.WriteLine("Biu~");
        }
        
    }
}
