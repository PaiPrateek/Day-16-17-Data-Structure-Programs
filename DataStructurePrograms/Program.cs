using System;

namespace DataStructurePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueInStacks.DriverMethod();
            // Week Day in Queue
            //WeekDay.DriverMethod();

            //Calender
            //Calender.DriverMethod();

            //Prime Numbere in 2D
            //PrimeNumber2Dimension.PrimeNumber();

            //int[] intarray = { 25, 63, 86, 95, 74, 32, 63, 45 };
            //var data = SearchNumber.FillHashtable(intarray);
            //SearchNumber.search(data, 45);

            //Calling cash counter constructor by creating the object
            //CashCounter cashcounter = new CashCounter();

            // calling driver method
            //DriverMethod();


            //Program p = new Program();
            //Console.WriteLine("Ordered List");

            ////Created  linked list
            //p.addFirst(96);
            //p.addFirst(63);
            //p.addFirst(74);
            //p.addFirst(101);
            //p.addFirst(92);
            //p.addFirst(12);
            //p.addFirst(14);

            //Console.WriteLine("Enter Student Name:");
            //int input = int.Parse(Console.ReadLine());

            //bool check = p.search(input);

            //if (check == true)
            //{
            //    // if input sata is present in the list then then that data is removed from the list
            //    p.remove(input);
            //}
            //else
            //{
            //    //if input data is not present in the list then that data is added into the list
            //    p.addFirst(input);
            //}

            ////Display the data present in the list after the completing the above said operations.
            //p.diplayData();

        }
        // Node Class Creation
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
        //Head Creation
        private Node head;

        //Createing  Method to add element at last position 
        public bool append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            return true;
        }
        //Creating method for add ing element at first postion - add()
        public bool addFirst(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        // Creating Method to Display the data in lIst
        public void diplayData()
        {
            if (head == null)
            {
                Console.WriteLine("Linkedlist is Empty");
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        // Create method for Removing the latest entered item - pop()
        public int pop()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            int obj = t.data;
            p.next = null;
            return obj;
        }

        // CReating method for getting latest added item - peek()
        public int peek()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }

            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }

            int obj = t.data;
            return obj;
        }

        // Creating method for searching - search()
        public bool search(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.next;
            }
            return false;
        }
        //Creating method for checking the list is empty or not - IsEmpty()
        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }

            return false;
        }
        //Craeting method for checking the size of the list - size()
        public int size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }

        public override string ToString()
        {
            if (head == null)
            {

                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.next;
            }
            return s;
        }
        //Creating method for getting the index of specified data
        public int index(int data)
        {
            int count = -1;
            if (head == null)
                return -1;
            Node t = head;
            while (t != null)
            {
                count++;
                if (t.data.Equals(data))
                    return count;
                t = t.next;
            }
            return -1;
        }
        //Creating method for inserting the data inthe specified index position
        public bool insert(int ind, int data)
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head.next;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            else
            {
                Console.WriteLine("Index is not in the specified Range");
                return false;
            }
        }
        // Creating method to Delete the elment from the Linked List 
        //public void delete(int index)
        //{
        //    if (index == 0)
        //    {
        //        head = head.next;
        //        return;
        //    }
        //    Node Temp = head;
        //    for (int i = 0; i < index - 1; i++)
        //    {
        //        Temp = Temp.next;
        //    }
        //    Temp.next = Temp.next.next;
        //}

        // Creating method to Delete the elment from the Linked List 
        public bool remove(int data)
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty");
            }
            if (head.next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data.Equals(data))
                {
                    pre.next = t.next;
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
        }
        //Creating method 
        public static void DriverMethod()
        {
            Console.Write("Enter an Arithmetic Equation: ");
            string ar = Console.ReadLine();
            Console.WriteLine(Balanced(ar));
        }
        //Creating method to check whether the input equation is balanced or not
        public static bool Balanced(string ar)
        {
            Stack<Char> stack = new Stack<Char>(ar.Length);
            for (int i = 0; i < ar.Length; i++)
            {
                char ch = ar[i];
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.IsEmpty())
                        return false;
                    if (ch == ')' && stack.Pop() != '(')
                    {
                        return false;
                    }
                }
            }
            return stack.IsEmpty();

        }

        //Creating the Stack Class
        public class Stack<Char>
        {
            int capacity;
            Char[] obj;
            int top = -1;
            public Stack(int capacity)
            {
                this.capacity = capacity;
                obj = new Char[capacity];
            }
            //Creating the push method to add the data into the stack
            public bool Push(Char data)
            {
                if (top == capacity - 1)
                {
                    Console.WriteLine("Stack overFlow");
                    return false;
                }
                obj[++top] = data;
                return true;
            }
            public Char Pop()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack Underflow");
                    return default(Char);
                }
                return obj[top--];
            }
            // Creating the Peek method to show the latest added element
            public Char Peek()
            {
                if (top == -1)
                {
                    Console.WriteLine("Stack is UnderFlow");
                    return (Char)default;
                }
                return obj[top];
            }
            //Creating the method to check the stack is empty or not
            public bool IsEmpty()
            {

                if (top == -1)
                    return true;
                else return false;
            }
            //Creating the method for checking the size of the stack
            public int Size()
            {
                return top + 1;
            }
            public override string ToString()
            {
                String s = "";
                for (int i = 0; i < capacity; i++)
                {
                    s = s + obj[i] + " ";
                }
                return s;
            }

        }
    }
}
