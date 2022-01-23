using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21likoclass
{
    internal class Program
    {



        public static void Main()
        {
            Console.WriteLine(Foo(30));
            Console.WriteLine("1.-----------------------------");



            int[] huage = { 1, 5, 2, 9, 3, 7, 6,4,8,0};
            bubble_sort(huage);
            foreach (var a in huage)
            {
                Console.WriteLine(a );
            }
            Console.WriteLine("2.-----------------------------");



            Console.WriteLine("10的内数的阶乘");
            Console.WriteLine(jiecheng(10));
            Console.WriteLine("3.-----------------------------");



            Console.WriteLine("//产生一个int数组，长度为100，并向其中随机插入1-100，并且不能重复。");
            int[] arr = new int[100];
            ArrayList myList = new ArrayList();
            Random rad = new Random();
            while (myList.Count < 100)
            {
                int num = rad.Next(1, 101);
                if (!myList.Contains(num))
                {
                    myList.Add(num);
                }
            }
            for (int i = 0; i < 100; i++)
            {
                arr[i] = (int)myList[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }

            Console.WriteLine("\n4.-----------------------------\n");


            Console.WriteLine("有1、2、3、4个数字，能组成多少个互不相同且无重复数字的三位数？都是多少？");
            int count = 0; //统计个数    
            for (int bw = 1; bw <= 4; bw++)
            {
                for (int sw = 1; sw <= 4; sw++)
                {
                    if (sw != bw)  //很显然，只有百位和十位不同的情况下才能谈个位。    
                    {
                        for (int gw = 1; gw <= 4; gw++)
                        {
                            if (gw != sw && gw != bw)   //百位用过的，十位就不能用；百位和十位都用过的，个位就不能用    
                            {
                                count++;
                                Console.WriteLine("{0}{1}{2}", bw, sw, gw);
                            }
                        }
                    }
                }
            }
            Console.WriteLine("一共有{0}个", count);
            Console.WriteLine("5.-----------------------------");


            Console.WriteLine("C# 取两个数组的相同元素");
            string[] names = {"Adams","Arthur","Buchanan","Tsbuchis","ShCian","FuchsiaLinda","DecheChen","Lotheer","FindLanciCade",
            "SorchLand","JiangZheng","MisiiLoda","Gtod","Dfac","Lama","BakCades","Losangle","ZheWQ","GehengDahaLothi","ToryLandey",
            "DakaLothy","BthLanda","MenNorth","Fith","FoxMain","DontM","Saobba","Del","Sala","Ghero","BhthLaPhda"};
            IEnumerable<string> skip = names.Skip(10);
            IEnumerable<string> take = names.Take(11);
            //取出两个序列中交集部分，按理论应该输出JiangZheng
            IEnumerable<string> intersect = skip.Intersect(take);
            foreach (var s in intersect)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("6-----------------------------");

            Console.WriteLine(".有一个字符串 I am a good man,设计一个函数,返回 man good a am I");
            Reverse();
            Console.WriteLine("7.-----------------------------");

            Console.WriteLine("有一个10个数的数组，计算其中不重复数字的个数。{3,5,9,8,10,5,3},用HashSet。");
            int[] values = { 3, 5, 9, 8, 10, 5, 3 };
            HashSet<int> set = new HashSet<int>();
            foreach (int i in values)
            {
                set.Add(i);
            }
            foreach (int i in set)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("8.-----------------------------");
            Console.WriteLine("百鸡百钱：公鸡2文钱一只，母鸡1文钱一只，小鸡半文钱一只，总共只有100文钱，如何在凑够100只鸡的情况下刚好花完100文钱？利用for嵌套+if筛选。");
            jitu();
            Console.ReadKey();
        }

        public static void jitu()
        {
            int sum = 0;
            for (int x = 0; x <= 50; x++)
            {
                for (int y = 0; y <= 100; y++)
                {
                    for (int z = 0; z <= 200; z++)
                    {
                        if (x + y + z == 100 && 2 * x + y + 0.5 * z == 100)
                        {
                            sum++;
                            Console.WriteLine("第" + sum + "种方法：" + x + "只公鸡，" + y + "只母鸡，" + z + "只小鸡。");
                        }
                    }
                }
            }
            Console.WriteLine("共有" + sum + "中方法。");
        }
        //一列数的规则如下: 1、1、2、3、5、8、13、21、34...... 求第30位数是多少，用递归算法实现
        public static int Foo(int i)
        {

            if (i <= 0) return 0;
            else if (i > 0 && i <= 2) return 1;
            else return Foo(i - 1) + Foo(i - 2);

        }
        //请编程实现一个冒泡排序算法？
        public static void bubble_sort(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i; j < x.Length; j++)
                {
                    if (x[i] < x[j])　　  //从大到小排序
                    {
                        int temp;
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;
                    }
                }
            }
        }
        //请编写一个函数，能够计算10以内数的阶乘，尽量采用递归算法。（10!=3628800）。
        public static int jiecheng(int n)
        {
            if (n == 1)
                return 1;
            else if (n == 2)
                return 2;
            else
                return n * jiecheng(n - 1);
        }

        public static string Reverse()
        {
            string s = "I am a good man";
            string[] arr = s.Split(' ');
            string res = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                res += arr[i];
                if (i > 0)
                    res += " ";
            }
            return res;
        }
    }

}
