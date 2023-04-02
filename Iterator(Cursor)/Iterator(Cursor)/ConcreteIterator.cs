//Bu sınıf, IIterator arayüzünü uygular ve koleksiyonun üzerinde dolaşmak için kullanılır.
public class ConcreteIterator : IIterator
{

    private ConcreteAggregate _aggregate;
    //koleksiyonu temsil eder (_aggregate)

    private int _current = 0;
    //mevcut durumu tutar (_current)

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this._aggregate = aggregate;
    }

    public object CurrentItem()
    {
        return _aggregate[_current];
    }

    public bool HasNext()
    {
        return _current < _aggregate.Count;
    }

    public object Next()
    {
        object result = null;
        if (HasNext())
        {
            result = _aggregate[_current];
            _current++;
        }
        return result;
    }
}
