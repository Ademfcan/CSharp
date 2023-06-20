public class DoublyLinkedListNode<T> where T : IEquatable<T>
{
    public T value;
    private DoublyLinkedListNode<T>? next;
    private DoublyLinkedListNode<T>? prev;

    public DoublyLinkedListNode(T val)
    {
        value = val;
        next = null;
        prev = null;
    }

    public DoublyLinkedListNode<T>? Next
    {
        get { return next; }
        set { next = value; }
    }

    public DoublyLinkedListNode<T>? Prev
    {
        get { return prev; }
        set { prev = value; }
    }
    
    public bool AreEqual(T obj1, T obj2)
    {
        return obj1.Equals(obj2);
    }

    // override object.Equals
    public override bool Equals(object obj)
    {
        //
        // See the full list of guidelines at
        //   http://go.microsoft.com/fwlink/?LinkID=85237
        // and also the guidance for operator== at
        //   http://go.microsoft.com/fwlink/?LinkId=85238
        //
        
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        
        // TODO: write your implementation of Equals() here
        // throw new System.NotImplementedException();
        return base.Equals (obj);
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        //throw new System.NotImplementedException();
        return base.GetHashCode();
    }

}

    

