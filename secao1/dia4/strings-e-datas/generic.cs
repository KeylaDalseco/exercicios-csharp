public class GenericList<T>
{
    private class Node
    {
        public T Value;
        public Node? Next;

        public Node(T t)
        {
            Value = t;
            Next = null;
        }
    }

    private Node Head;

    public GenericList()
    {
        Head = null;
    }

    public void Add(T input) 
    {
        if (Head == null)
        {
            Head = new Node(input);
            Console.WriteLine("Nó Head criado!");
        }
        else
        {
            //Encontra onde inserir o próximo nó na lista.
            Node lastNode = Head;
            while(lastNode.Next != null)   lastNode = lastNode.Next;

            lastNode.Next = new Node(input);                        
        }
    }
    public void Add(T input) {... }
}

// PARA INSTANCIAR A CLASSE
GenericList<int> list1 = new GenericList<int>();
list1.Add(1);
GenericList<string> list2 = new GenericList<string>();
list2.Add("Olá");
GenericList<SomeClass> list3 = new GenericList<SomeClass>();
list3.Add(new SomeClass());