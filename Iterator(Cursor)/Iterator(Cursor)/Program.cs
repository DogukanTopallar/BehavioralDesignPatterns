using System;
using System.Collections;

namespace Iterator_Cursor_
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "item 1";
            aggregate[1] = "item 2";
            aggregate[2] = "item 3";
            aggregate[3] = "item 4";

            ConcreteAggregate aggregate1 = new ConcreteAggregate();
            aggregate[0] = "item 12";
            aggregate[1] = "item 3523";
            aggregate[2] = "item 3444444444444";
            aggregate[3] = "item 4555";
            aggregate[3] = "item Dogukan";
            aggregate[3] = "item Ali";

            IIterator iterator = aggregate.CreateIterator();
            IIterator iterator1 = aggregate1.CreateIterator();

            while (iterator1.HasNext())
            {
                Console.WriteLine(iterator1.Next());
            }

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }
        }

    }
}
