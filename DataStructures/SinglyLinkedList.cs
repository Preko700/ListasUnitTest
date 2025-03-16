namespace DataStructures
{
    public class SinglyLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node? Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node? head;
        public int Count { get; private set; }

        public SinglyLinkedList()
        {
            head = null;
            Count = 0;
        }

        // Agrega un elemento al inicio de la lista
        public void AddFirst(T data)
        {
            var newNode = new Node(data)
            {
                Next = head
            };
            head = newNode;
            Count++;
        }

        // Agrega un elemento al final de la lista
        public void AddLast(T data)
        {
            var newNode = new Node(data);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }

            Count++;
        }

        // Elimina la primera ocurrencia del elemento indicado
        public bool Remove(T data)
        {
            if (head == null) return false;

            if (EqualityComparer<T>.Default.Equals(head.Data, data))
            {
                head = head.Next;
                Count--;
                return true;
            }

            Node current = head;
            while (current.Next != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Next.Data, data))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        // Verifica si la lista contiene el elemento
        public bool Contains(T data)
        {
            var current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                    return true;
                current = current.Next;
            }

            return false;
        }

        // Limpia la lista
        public void Clear()
        {
            head = null;
            Count = 0;
        }

        // Obtiene el elemento en el índice especificado
        public T GetAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            var current = head;
            for (int i = 0; i < index; i++)
            {
                current = current!.Next;
            }

            return current!.Data;
        }
    }

    public class DoublyLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node? Next { get; set; }
            public Node? Prev { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
                Prev = null;
            }
        }

        private Node? head;
        private Node? tail;
        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        // Agrega un elemento al inicio de la lista
        public void AddFirst(T data)
        {
            var newNode = new Node(data);

            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }

            Count++;
        }

        // Agrega un elemento al final de la lista
        public void AddLast(T data)
        {
            var newNode = new Node(data);

            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }

            Count++;
        }

        // Elimina la primera ocurrencia del elemento indicado
        public bool Remove(T data)
        {
            if (head == null) return false;

            Node? current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                {
                    if (current.Prev != null)
                        current.Prev.Next = current.Next;
                    else
                        head = current.Next;

                    if (current.Next != null)
                        current.Next.Prev = current.Prev;
                    else
                        tail = current.Prev;

                    Count--;
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        // Verifica si la lista contiene el elemento
        public bool Contains(T data)
        {
            Node? current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Data, data))
                    return true;
                current = current.Next;
            }

            return false;
        }

        // Limpia la lista
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        // Obtiene el elemento en el índice especificado
        public T GetAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            Node? current;

            // Determinar si es más eficiente empezar desde la cabeza o desde la cola
            if (index < Count / 2)
            {
                current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current!.Next;
                }
            }
            else
            {
                current = tail;
                for (int i = Count - 1; i > index; i--)
                {
                    current = current!.Prev;
                }
            }

            return current!.Data;
        }
    }
}
