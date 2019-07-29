using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {


        //    static void Main(string[] args)
        //    {

        //        //string longUrl ="https://leetcode.com/problems/design-tinyurl";
        //        //string res = "";

        //        //Encode encode = new Encode();
        //        //res = encode.EncodeUrl(longUrl);
        //        //Console.WriteLine(res);
        //        //res = encode.decode(res);

        //        //int[] arr = new int[10]
        //        //{
        //        //    1,5,4,11,20,8,2,98,90,16
        //        //};

        //        //mergeSort ms = new mergeSort();
        //        //ms.mergesort(arr, 0, arr.Length - 1);
        //        //for (int i = 0; i < arr.Length; i++)
        //        //    Console.WriteLine(arr[i]);

        //        //string[] A = { "cool", "lock", "cook" };
        //        //find_common_characters fcc = new find_common_characters();
        //        //fcc.CommonChars(A);

        //        //ListNode list = new ListNode(0);
        //        //ListNode head = list;
        //        //for (int i =1; i<5; i++)
        //        //{
        //        //    list.next = new ListNode(i);
        //        //    list = list.next;
        //        //}
        //        //reverse_linked_list re = new reverse_linked_list();
        //        //re.reverseList(head);

        //        //MinimumCosttoMergeStones mcs = new MinimumCosttoMergeStones();
        //        //mcs.RunMergeStone();

        //        //Partition_Labels pl = new Partition_Labels();
        //        //pl.runCode();

        //        //Sum_of_leaf_nodes sln = new Sum_of_leaf_nodes();
        //        //sln.RunCode();

        //        //Log_Sorting_AMOA lsAM = new Log_Sorting_AMOA();
        //        //lsAM.runCode();

        //        //optimalUtilization pu = new optimalUtilization();
        //        //pu.runCode();

        //        //MinimumSpanningTree mt = new MinimumSpanningTree();
        //        //mt.runCode();

        //        //Delegates dl = new Delegates();
        //        //dl.runCode();

        //        VirtualClass sc = new VirtualClass();
        //        sc.

        //    }
        //}

        public class Encode
        {
            public string dict = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            public Dictionary<int, string> m = new Dictionary<int, string>();
            public Dictionary<int, string> idm = new Dictionary<int, string>();
            public int id = 1;

            public string EncodeUrl(string longUrl)
            {
                string res = "http://tiny.url/" + base10ToBase62(id);
                m.Add(id, res);
                idm.Add(id, longUrl);

                return res;
            }

            public string decode(string shortUrl)
            {
                string pre = " http://tiny.url/";
                shortUrl = pre + shortUrl;
                int n = base62toBase10(shortUrl);
                return idm[n];
            }

            public int base62toBase10(string s)
            {
                int n = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    n = n * 62 + s.IndexOf(s[i]);
                }
                return n;
            }

            public string base10ToBase62(int n)
            {
                string str = "";
                while (n != 0)
                {
                    str = str + dict[n % 62];
                    n /= 62;
                }
                while (str.Length != 6)
                {
                    str = "0" + str;
                }
                return str;
            }
        }
    }
}
