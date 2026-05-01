public class Solution {
    public int CharacterReplacement(string s, int k) {
        int res =0;
        int l =0;
        int r =0;
        var alphabet = new int[26];
        while(l<=r && r<s.Length ){
            alphabet[s[r] -'A' ] +=1;
            var mostFrequentCharSize = alphabet.OrderByDescending(x => x).First();
            var wlength = (r+1)-l;
            if((wlength - mostFrequentCharSize) <= k ) res =wlength;
            else{
                alphabet[s[l] -'A'] -=1;
                l++;
            }
            r++;
        }
        return res;
    }
}