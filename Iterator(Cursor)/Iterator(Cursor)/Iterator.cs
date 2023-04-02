// Koleksiyondaki öğeleri dolaşmak için bir arayüz sağlar.
public interface IIterator
{
    bool HasNext();
    object Next();
    object CurrentItem();
}
