using System.Text;
public class MyLinkedList
{
    private LinkedListNode? head;
    private LinkedListNode? tail;

    public MyLinkedList()
    {
    }

    public void addNode(int val)
    {
        if (head == null)
        {
            head = new LinkedListNode(val);
            tail = head;
        }
        else
        {
            tail.Next = new LinkedListNode(val);

           

            tail = tail.Next;
        }
    }

    public void Print(){
        
        Console.WriteLine(this.ToString());
    }

    public void Remove(int v){
        LinkedListNode? temp = head;
        LinkedListNode? prev = head;
        if(head.Value == v){
            head = head.Next;
        }
        while(temp != null){
            if(temp.Value != v){
                prev = temp;
                temp = temp.Next;
            }
            else{
                prev.Next = temp.Next;
                break;
            }
        }

    }

    public override String ToString(){
        StringBuilder sb = new StringBuilder();
        LinkedListNode? temp = head;
        while(temp != null)
        {
            sb.Append(temp.Value).Append("\n");
            temp = temp.Next;
        }
        return sb.ToString();
    }
}