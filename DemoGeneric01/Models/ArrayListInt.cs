using System.Collections;

namespace DemoGeneric01.Models;

public class ArrayListInt
{
    private readonly ArrayList _arrayList;

    public int this[int index]
    {
        get
        {
            return (int)_arrayList[index];
        }
        set
        {
            _arrayList[index] = value;
        }
    }

    public ArrayListInt()
    {
        _arrayList = new ArrayList();
    }


    public void Add (int value)
    {
        _arrayList.Add(value);
    }
}
