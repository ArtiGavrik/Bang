using System;

namespace Project
{
    class Program
    {
        class A
        {
        }
        class B : A
        {
            public B(object a)
            {
                this.a = a;
            }
            public object a;
        }
        class C : B
        {
            public C(object a, object b, object c) : base(a)
            {
                this.b = b;
                this.c = c;
            }
            public object b;
            public object c;
        }
        static void Main(string[] args)
        {
            C c = new C(new A(), new A(), new B(new A()));
        }
    }
}