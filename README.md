## Description:
### Task
A rectangle with sides equal to even integers a and b is drawn on the Cartesian plane. Its center (the intersection point of its diagonals) coincides with the point (0, 0), but the sides of the rectangle are not parallel to the axes; instead, they are forming ```45 degree``` angles with the axes.

How many points with integer coordinates are located inside the given rectangle (including on its sides)?
### Example
For ```a = 6 and b = 4```, the output should be ```23```.

The following picture illustrates the example, and the 23 points are marked green.

![Example image](https://github.com/IvanovArtyom/Simple-Fun-27-Rectangle-Rotation-/blob/master/blob.png)
### Input/Output
- ```[input]``` integer ```a```  
A positive ```even``` integer.  
Constraints: ```2 ≤ a ≤ 10000```.

- ```[input]``` integer ```b```  
A positive ```even``` integer.  
Constraints: ```2 ≤ b ≤ 10000```.

- ```[output]``` an integer  
The number of inner points with integer coordinates.
### My solution
``` C#
using System;

namespace myjinxin
{   
    public class Kata
    {   
        readonly double cellLength = Math.Sqrt(2);
      
        public int RectangleRotation(int a, int b)
        {
            return CalcFullCellsNumber(a) * CalcFullCellsNumber(b) +
                CalcHalfCellsNumber(a) * CalcHalfCellsNumber(b);
        }

        public int CalcFullCellsNumber(int n)
        {
            return (int)(n / 2d / cellLength) * 2 + 1;
        }

        public int CalcHalfCellsNumber(int n)
        {
            return ((int)((n / 2d - cellLength / 2) / cellLength) + 1) * 2;
        }
    }
}
```
