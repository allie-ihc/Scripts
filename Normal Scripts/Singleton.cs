using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton 
{
    //if type = 'e', prints even nums. If type = 'o', prints odd nums
    char type = ' ';    
    int count = -1;
    public Singleton(char type)
    {
        this.type = type;
    }
    public int countUp()
    {
        count++;
        if(count%2 == 0 && type == 'e')
        {
            return count;
        }
        else if(count%2 == 1 && type == 'o')
        {
            return count;
        }
        else
        {
            return -1;
        }
    }
}
