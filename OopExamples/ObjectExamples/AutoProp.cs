using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ObjectExamples
{
    public class AutoProp
    {
        public class Point
        { //классический Get Set
            private int x;
            public  void SetX(int x)
            {this.x = x; }
            public  int GetX()
            { return x;  }
        }
    }
}
