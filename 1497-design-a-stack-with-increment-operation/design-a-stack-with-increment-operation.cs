public class CustomStack {

int[] stack;
int top = -1;
    public CustomStack(int maxSize) {
    this.stack = new int[maxSize];
    }
    
    public void Push(int x) {
        if(top == stack.Length -1){
            return;
        }
        top++;
    stack[top] = x;
    }
    
    public int Pop() {
        if(top == -1){
            return -1;
        }
        int a = stack[top];
        stack[top] = 0;
        top--;
        return a;
    }

    
    public void Increment(int k, int val) {
        
        int a = 0;
        for(int i=0;i<k;i++){
            if(i< stack.Length && stack[i] !=0)
            {
                stack[i] = stack[i] + val;
            }
        }


    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */