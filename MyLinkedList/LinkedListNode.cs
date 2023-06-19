public class LinkedListNode
{
    private int value;
    private LinkedListNode? next;

    public LinkedListNode(int v)
    {
        value = v;
        next = null;
    }

    public int Value {
        get {
            return this.value;
        }
    }

    public LinkedListNode? Next
    {
        get {
            return this.next;
        }

        set 
        {
            this.next = value;
        }
    }


}