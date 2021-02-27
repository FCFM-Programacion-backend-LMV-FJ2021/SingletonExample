using System;
using System.Collections.Generic;
using System.Text;

namespace SingletoExampleDW_LMV
{
    class SingletonObject
    {
        public int x { get; set; }
        public int y { get; set; }
        private SingletonObject()
        {
            x = 20;
            y = 40;
        }

        private static SingletonObject _incance;

        public static SingletonObject GetInstance()
        {

            if (_incance == null)
                _incance = new SingletonObject();

            return _incance;
        }
    }
}
