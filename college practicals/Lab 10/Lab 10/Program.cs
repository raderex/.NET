using System;

namespace sealedClass
{
    class Animal { }
    sealed class Dog : Animal { }
    // The following class will produce an error because Dog is sealed.
    // class Pug : Dog { }
    class Program
    {
        static void Main(string[] args) { }
    }
}
