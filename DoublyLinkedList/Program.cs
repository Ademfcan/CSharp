public class Program{
    public static void Main(String[] args){
        LinkedListA<String> test = new LinkedListA<String>();
        test.AddValue("1");
        test.AddValue("2");
        test.AddValue("3");

        test.Print();
        test.RemoveValue("1");
        test.Print();
    }
}