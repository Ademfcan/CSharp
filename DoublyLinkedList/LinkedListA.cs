using System.Text;
public class LinkedListA<T> where T : IEquatable<T> {
    DoublyLinkedListNode<T>? Head;
    DoublyLinkedListNode<T>? Tail;
    
    public LinkedListA(){
        Head = null;
        Tail = null;
    }

    public void AddValue(T val){
        if(Head == null){
            Console.WriteLine("here!!");
            Head = new DoublyLinkedListNode<T>(val);
            Tail = Head;
        }
        else{
            Console.WriteLine("there!!");
            DoublyLinkedListNode<T> temp = Head;
            while(temp.Next != null){
                temp = temp.Next;
            }
            temp.Next = new DoublyLinkedListNode<T>(val);
            temp.Next.Prev = temp;
            Tail = temp;

        }
    }

    public void RemoveValue(T val){
        if(Head.value.Equals(val)) {
            Head = Head.Next;
        }
        else{
            DoublyLinkedListNode<T> temp = Head;
            while(temp != null){
                
                if(temp.value.Equals(val)){
                    Console.WriteLine(temp.Prev == null);
                    temp.Prev.Next = temp.Next;
                }
                temp = temp.Next;
            }
        }
    }

    public void Print(){
        StringBuilder sb = new StringBuilder();
        DoublyLinkedListNode<T> temp = Head;
        while(temp != null){
            sb.Append($"{temp.value},");
            temp = temp.Next;
        }
        Console.WriteLine(sb);
    }
}