

    class Node {
        public int key;
        public int val;
        public Node next;

        public Node(int key,int val){
            this.key = key;
            this.val = val;
        }
    }
public class MyHashMap {


    private Node [] storage ;
        public MyHashMap() {
            storage = new Node[10000];
    }
    
    public int hash(int key){
        return key%10000;
    }

    private Node find(Node head, int key){
        Node prev = null;
        Node curr = head;

        while(curr!=null && curr.key !=key){
            prev = curr;
            curr = curr.next;
        }
        return prev;
    }
    public void Put(int key, int value) {
        int hashval = hash(key);
        if(storage[hashval] == null) {
            storage[hashval] = new Node(-1,-1);
        }

        Node prev = find(storage[hashval],key);
        if(prev.next == null){
            prev.next = new Node(key,value);
        }else{
            prev.next.val = value;
        }
    }
    
    public int Get(int key) {
        int hashval = hash(key);
        if(storage[hashval] == null){return -1;}
        Node prev = find(storage[hashval],key);
        if(prev.next == null){return -1;}
        return prev.next.val;
    }
    
    public void Remove(int key) {
         int hashval = hash(key);
        if(storage[hashval] == null){return ;}
        Node prev = find(storage[hashval],key);
        if(prev.next == null){
            return;
        }
        else{
            Node curr = prev.next;
            prev.next = curr.next;
            curr.next = null;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */