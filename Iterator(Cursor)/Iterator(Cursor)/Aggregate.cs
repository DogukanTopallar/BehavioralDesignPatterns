//Depolanan nesleri teker teker dolaşmak için bir yöntem sağlar. -> CreateIterator
public interface IAggregate
{
    //Iterator nesnesi oluşturur.
    IIterator CreateIterator();

}
