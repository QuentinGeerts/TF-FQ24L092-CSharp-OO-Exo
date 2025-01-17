using System.Collections;

namespace DemoGeneric01.Models;

public class ArrayListString
{
    private readonly ArrayList _arrayList;

    public string this[int index]
    {
        get
        {
            return (string)_arrayList[index];
        }
        set
        {
            _arrayList[index] = value;
        }
    }

    public ArrayListString()
    {
        _arrayList = new ArrayList();
    }


    public void Add(string value)
    {
        _arrayList.Add(value);
    }
}
