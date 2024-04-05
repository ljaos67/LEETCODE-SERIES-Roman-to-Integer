public class Solution {
    
    public int retValue(char c, char p)
    {
        switch(c)
        {
            case 'I':
            return 1;
            break;
            case 'V':
            if(p == 'I')
            {
                return 3;
            }
            else
            {
                return 5;
            }
            break;
            case 'X':
            if(p == 'I')
            {
                return 8;
            }
            else
            {
                return 10;
            }
            break;
            case 'L':
            if(p == 'X')
            {
                return 30;
            }
            else
            {
                return 50;
            }
            break;
            case 'C':
            if(p == 'X')
            {
                return 80;
            }
            else
            {
                return 100;
            }
            break;
            case 'D':
            if(p == 'C')
            {
                return 300;
            }
            else
            {
                return 500;
            }
            break;
            case 'M':
            if(p == 'C')
            {
                return 800;
            }
            else
            {
                return 1000;
            }
            break;
            default:
            return -1;
            break;
        }
    }
    
    public int RomanToInt(string s) 
    {
        char prevChar = 'a';
        int total = 0;
        for(int i = 0; i < s.Length; i++)
        {
            total += retValue(s[i],prevChar);
            prevChar = s[i];
        }
        return total;    
    }
}
