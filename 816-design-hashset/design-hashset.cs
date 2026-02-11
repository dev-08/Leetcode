public class MyHashSet {
        private int bucket;
        private int bucketItems;
        private bool [][] storage;

    public MyHashSet() {
        this.bucket = 1000;
        this.bucketItems = 1000;
        storage = new bool [bucket][];
    }
    


    public void Add(int key) {
        int a = key%bucket;
         int nearval = key/1000;
        if(storage[a] == null){
            if(a == 0){
            storage[a] = new bool [bucketItems+1];}
            else{
                 storage[a] = new bool [bucketItems];
            }
        }

      

        storage[a][nearval] = true;

    }
    
    public void Remove(int key) {
          int a = key%bucket;
         int nearval = key/1000;
         if(storage[a] == null) return;
         storage[a][nearval] = false; 
    }
    
    public bool Contains(int key) {
       int a = key%bucket;
         int nearval = key/1000;
         if(storage[a] == null) return false;
         return storage[a][nearval]; 
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */