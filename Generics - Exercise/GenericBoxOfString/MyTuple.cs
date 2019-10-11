﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class MyTuple<T1, T2>
    {
        private T2 item2;

        public MyTuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public T1 Item1 { get; private set; }

        public T2 Item2
        {
            get { return this.item2; }
            private set { this.item2 = value; }
        }
    }
}
