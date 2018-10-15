using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class AddToCollection : ScriptableObject
{

    public ObjectCollection Collection;

    public void Call(ObjectCollection obj)
    {
        Collection.ObjectList.Add(obj);
    }
}
