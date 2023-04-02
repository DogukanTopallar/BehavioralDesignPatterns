using System.Collections.Generic;
//Bu sınıf, IAggregate arayüzünü uygular ve koleksiyonu temsil eder. 
public class ConcreteAggregate : IAggregate
{ 
    // "_items" özelliği, koleksiyonda depolanan öğelerin listesini tutar.
    private List<object> _items = new List<object>();

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }

    public int Count => _items.Count;

    public object this[int index]
    {
        get { return _items[index]; }
        set { _items.Insert(index, value); }
    }
}
