using System;
using System.Collections.Generic;
using System.Text;

namespace IMiniMq
{
   public interface IClientBlock
    {
        public void Push(string key, byte[] bytes);

        public byte[] Poll(string key);
      
    }
}
