﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Threeuple<T1, T2, T3> : MyTuple<T1, T2>
    {
        private T3 item3;

        public Threeuple(T1 item1, T2 item2, T3 item3) : base(item1, item2)
        {
            this.Item3 = item3;
        }

        public T3 Item3
        {
            get { return this.item3; }
            private set { this.item3 = value; }
        }
    }
}
