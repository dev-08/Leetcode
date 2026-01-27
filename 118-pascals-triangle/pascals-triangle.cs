public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        

     IList<IList<int>> result = new List<IList<int>>();
        result.Add(new List<int> {1});
        for(int i = 1 ; i<numRows ; i++){
        IList<int> temp = new List<int>();
            for(int j=0 ; j<=i ; j++){
                    if(j==0) { temp.Add(1) ; continue;}
                    if(j==i) { temp.Add(1); continue;}

                      temp.Add(result[i-1][j] + result[i-1][j-1]);
            }
            result.Add(temp);
        }
        return result;
    }
}