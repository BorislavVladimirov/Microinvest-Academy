using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Test1
    {
        private int id;
        private string testName;

        public override bool Equals(object obj)
        {
            return obj is Test1 test &&
                   id == test.id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id);
        }
    }
}
