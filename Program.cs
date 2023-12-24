


class MyClass
{
    public int a;
    public static int b;
}

class MyClass2
{
    private static int b;

    public void SetB(int b)
    {
        MyClass2.b = b;
    }

    public void PrintB()
    {
        Console.WriteLine(b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass.b = 15;
        MyClass myClass = new MyClass();
        myClass.a = 44;

        MyClass myClass2 = new MyClass();   
        myClass2.a = 22;  
        

        MyClass2 myClass3 = new MyClass2();
        myClass3.SetB(12);
        myClass3.PrintB();
    }
}