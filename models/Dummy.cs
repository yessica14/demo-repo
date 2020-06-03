using System;

namespace firstApp.models
{
    public class Dummy
    {
        public string  DummyId{ get{
          return Guid.NewGuid().ToString();
        } }
    }
}