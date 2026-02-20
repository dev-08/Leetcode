public class Solution {
    public bool ValidWordSquare(IList<string> words) {
        for(int i=0; i< words.Count; i++){
            for(int j = 0;j<words[i].Length;j++){
                 char h = '\0';
                    char v = '\0';
                if(i <words.Count &&  j< words[i].Length) {
                     h = words[i][j];
                }
                if(j<words.Count && i<words[j].Length){
                    v = words[j][i];
                }

          
              

                if(h!=v){
                    return false;
                }
            }
        }
        return true;
    }
}