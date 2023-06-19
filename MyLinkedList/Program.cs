class Program
{
    public static void Main(string[] args)
    {

        MyLinkedList list = new MyLinkedList();
        for(int i =0; i<2000; i++){
            list.addNode(i);
  
        }
        list.Print();
        
        
        /*
        String? name  = Input("What is your name");
        Console.WriteLine("Hello " + name.ToLower());
        */
    }

    public static string? Input(String prompt){
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    private static LinkedListNode? buildNode(LinkedListNode prev, int n){
        LinkedListNode node = new LinkedListNode(n);
        prev.Next = node;
        return node;
    }
}
