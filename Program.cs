using System;
class Program
{
    
    static void Main(string[] args)
    {
        int LtoM = 2;
        int MtoS = 3;
        bool exit = false;
        Queue<int> queue = new Queue<int>();
        while(exit == false)
        {
            string friut = Console.ReadLine();
            switch(friut)
            {
                case "L":
                {
                    queue.Push(1);
                }
                break;
                case "M":
                {
                    queue.Push(2);
                }
                break;
                case "S":
                {
                    queue.Push(3);
                }
                break;
                default:
                {
                    exit = true;
                }
                break;
            }
        }
        while(queue.GetLength()>0)
        {
            int ifriut = queue.Pop();
            Console.Write(ifriut);

            if(ifriut==1)
            {
                for(int i = 0;i<LtoM;i++)
                {
                    queue.Push(2);
                }
            }
            else if(ifriut==2)
            {
                for(int i = 0;i<MtoS;i++)
                {
                    queue.Push(3);
                }
            }
        }
    }
}