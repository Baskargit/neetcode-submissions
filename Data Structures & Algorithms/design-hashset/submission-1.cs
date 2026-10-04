public class MyHashSet {

    private const int BUCKET_SIZE = 100;
    Node[] hashTable = null;


    public MyHashSet() 
    {
        hashTable = new Node[BUCKET_SIZE];

        for(int i=0; i<BUCKET_SIZE; i++)
            hashTable[i] = null;
    }
    
    public void Add(int key) {
        int hashIndex = Hash(key);

        if(hashTable[hashIndex] == null)
        {
            hashTable[hashIndex] = new Node(key);
        }
        else
        {
            Node node = hashTable[hashIndex];

            while(node != null)
            {
                if(node.num == key)
                    return;
                
                if(node.next == null)
                    break;
                    
                node = node.next;
            }

            // Add new node at end
            node.next = new Node(key);
        }
    }
    
    public void Remove(int key) {
        int hashIndex = Hash(key);
        Node node = hashTable[hashIndex];

        if(node == null)
            return;

        if(node.num == key)
        {
            hashTable[hashIndex] = node.next;
            return;
        }
            

        Node previous = null;
        Node current = node;

        while(current != null)
        {
            if(current.num == key)
            {
                previous.next = current.next;
                return;
            }

            previous = current;
            current = current.next;
        }
    }
    
    public bool Contains(int key) {
        int hashIndex = Hash(key);
        Node node = hashTable[hashIndex];

        while(node != null)
        {
            if(node.num == key)
                return true;
            
            node = node.next;
        }

        return false;
    }

    private int Hash(int key)
    {
        return key % BUCKET_SIZE;
    }

    private class Node
    {
        public int num;
        public Node next;

        public Node(int num)
        {
            this.num = num;
            next = null;
        }
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */