namespace LinkedList
{
    class Node
    {
        public Node(User data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public User Data;
        public Node Next;
    }

    class UserLinkedList
    {
        private Node first = null!;

        public void AddFirst(User user)
        {
            Node node = new Node(user, first);
            first = node;
        }

        //Opgave 4, SortedUsedLinkedList AddFirst metode omdannes til AddSorted metode
        public void AddSorted(User user)
        {
            Node newNode = new Node(user, null);
            if (first == null || first.Data.Id > user.Id)
            {
                newNode.Next = first;
                first = newNode;
            }
            else
            {
                Node current = first;
                while (current.Next != null && current.Next.Data.Id < user.Id)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
            }
        }

        public object RemoveFirst()
        {
            if (first == null)
            {
                return null;
            }
            
            Node node = first;
            first = node.Next;
            return node.Data;

        }

        public void RemoveUser(User user)
        {
            Node node = first;
            Node previous = null!;
            bool found = false;

            while (!found && node != null)
            {
                if (node.Data.Name == user.Name)
                {
                    found = true;
                    if (node == first)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    previous = node;
                    node = node.Next;
                }
            }
        }

        public User GetFirst()
        {
            return first.Data;
        }

        public User GetLast()
        {
            Node node = first;
            while (node.Next != null)
            {
                node = node.Next;
            }
            return node.Data;
        }

        //Kan også laves så den er konstand tid, hvis man opretter en counter på datastrukturen 
        public int CountUsers()
        {
            Node node = first;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }

        public bool? Contains(User user)
        {
            Node node = first;
            while (node != null)
            {
                if (node.Data.Name == user.Name)
                {
                    return true;
                }
                node = node.Next;
            }
            return false;
        }

        public override String ToString()
        {
            Node node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + ", ";
                node = node.Next;
            }
            return result.Trim();
        }
    }
}