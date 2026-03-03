class Solution {
public:
    string findValidPair(string s) {
  unordered_map<char,int> freq;

    // count frequency
    for(char c : s)
    {
        freq[c]++;
    }

    // check adjacent pairs
    for(int i = 0; i < s.size()-1; i++)
    {
        char a = s[i];
        char b = s[i+1];

        if(a != b)
        {
            if(freq[a] == (a - '0') && freq[b] == (b - '0'))
            {
                return string() + a + b;
            }
        }
    }

    return "";
    }
};