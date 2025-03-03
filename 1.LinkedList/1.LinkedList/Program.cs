public class Node 
{
    public object Value {  get; set; }  
    public Node Next {  get; set; }
    
    public Node(object value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;
    private Node tail;

    public LinkedList()
    {
        head = null;
        tail = null;
    }

    public void Add(object value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
    }

    public void Print()
    {
        Node current = head;

        while (current != null) 
        { 
            Console.Write(current.Value + " --> ");
            current = current.Next; 
        }
        Console.WriteLine("null");
    }

    public object Get(int index)
    {
        if (index < 0)
        {
            throw new ArgumentOutOfRangeException("Индексът не може да бъде отрицателен.");
        }

        Node current = head;
        int currentIndex = 0;

        while (current != null)
        {
            if (currentIndex == index)
            {
                return current.Value;
            }
            current = current.Next;
            currentIndex++;
        }
        throw new ArgumentOutOfRangeException("Индексът е извън границите на списъка.");
    }

    public void Remove(int index) 
    { 
        if(index < 0 || head == null)
        {
            throw new ArgumentOutOfRangeException("Невалиден индекс.");
        }

        if (index == 0)
        {
            head = head.Next;
            if (head == null)
            {
                tail = null;
            }
            return;
        }
        Node current = head;
        Node previous = null;
        int currentIndex = 0;

        while (current != null && currentIndex < index) 
        {
            previous = current;
            current = current.Next;
            currentIndex++;
        }

        if(current == null)
        {
            throw new ArgumentOutOfRangeException("Индексът е извън границите на списъка.");
        }

        previous.Next = current.Next;

        if(current.Next == null)
        {
            tail = previous;
        }
    }

    public bool Contains(object item)
    {
        Node current = head;

        while (current != null)
        {
            if (current.Value.Equals(item))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

}

class Program
{
    static void Main()
    {
        LinkedList list = new LinkedList();

        list.Add(5);
        list.Add(10);
        list.Add(15);
        list.Add(20);
        list.Add(25);
        list.Add(35);
        list.Add(40);
        list.Add(45);
        list.Add(50);

        list.Print();

        Console.WriteLine(list.Get(0));

        list.Remove(4);
        list.Print();

        Console.WriteLine(list.Contains(5));
        Console.WriteLine(list.Contains(17));
    }
}
