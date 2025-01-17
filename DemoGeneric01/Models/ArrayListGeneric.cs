using System.Collections;

namespace DemoGeneric01.Models;

public class ArrayListGeneric<T>
{
    private readonly ArrayList _arrayList;

    public T this[int index]
    {
        get
        {
            return (T)_arrayList[index];
        }
        set
        {
            _arrayList[index] = value;
        }
    }

    public ArrayListGeneric()
    {
        _arrayList = new ArrayList();
    }


    public void Add(T value)
    {
        _arrayList.Add(value);
    }
}
