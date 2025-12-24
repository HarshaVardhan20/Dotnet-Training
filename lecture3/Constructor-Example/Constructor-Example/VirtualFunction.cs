using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSession
{
    public class Father
    {
        public virtual string InterestedOn()
        {
            return "I like to play cricket";
        }
    }
    public class Child: Father
    {
        public override string InterestedOn()
        {
            return "I like to play Moblie games";
        }
    }

}
