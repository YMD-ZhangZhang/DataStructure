using System;

namespace v1
{
    class Program
    {
        static void Main(string[] args)
        {
            TestData(new int[] { 1 });
            TestData(new int[] { 1, 2 });
            TestData(new int[] { 1, 2, 3 });
            TestData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.ReadKey();
        }

        /// <summary>
        /// 测试一组数据
        /// </summary>
        static void TestData(int[] data)
        {
            Node node = InitNodeList(data);
            Console.WriteLine();
            Console.WriteLine("处理前:");
            PrintNodeList(node);

            Node reversedNode = ReverseNodeList(node);
            Console.WriteLine();
            Console.WriteLine("处理后:");
            PrintNodeList(reversedNode);
        }

        /// <summary>
        /// 初始化链表
        /// </summary>
        static Node InitNodeList(int[] valueList)
        {
            Node head = null;
            Node last = null;

            for (int i = 0; i < valueList.Length; i++)
            {
                Node node = new Node();
                node.value = valueList[i];

                if (head == null)
                    head = node;

                if (last != null)
                    last.next = node;

                last = node;
            }

            return head;
        }

        /// <summary>
        /// 输出单链表
        /// </summary>
        static void PrintNodeList(Node node)
        {
            while (node != null)
            {
                Console.Write(node.value + ",");
                node = node.next;
            }
        }

        /// <summary>
        /// 单链表逆序
        /// </summary>
        static Node ReverseNodeList(Node head)
        {
            // 利用3个变量
            Node p1 = null, p2 = null, p3 = null;

            p1 = head;
            p2 = p1.next;

            while (p2 != null)
            {
                p3 = p2.next;
                p2.next = p1;

                p1 = p2;
                p2 = p3;
            }

            head.next = null;
            head = p1;
            return head;
        }
    }

    class Node
    {
        public Node next;
        public int value;
    }
}
