using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StrucPointData
{
    public static int[] Point(int count)
    {
        switch (count)
        {
            case 3:
                return new int[3]  { 0,1,2};
            case 4:
                return new int[12] { 0,1,2,0,1,3,1,2,3,0,2,3 };
            case 5:
                return new int[18] { 0,1,2,0,2,3,0,1,4,0,4,3,1,2,4,2,3,4};
            case 6:
                return new int[24] { 0,1,2,0,2,3,0,3,4,0,1,5,0,5,4,1,2,5,2,3,5,3,4,5};
            case 7:
                return new int[30] { 0,1,2,0,2,3,0,3,4,0,4,5,0,1,6,0,6,5,1,2,6,2,3,6,3,4,6,4,5,6};
            case 8:
                return new int[36] { 0,1,2,0,2,3,0,3,4,0,4,6,6,4,5,0,1,7,0,7,6,1,2,7,2,3,7,3,4,7,4,5,7,5,6,7 };
        }
        return null;
    }
}
