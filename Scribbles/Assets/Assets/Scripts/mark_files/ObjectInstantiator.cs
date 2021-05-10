using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiator : MonoBehaviour
{
    public static ObjectInstantiator objectInstantiator;
    public List<GameObject> objects = new List<GameObject>();

    public Vector3 defaultSpawn = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        objectInstantiator = this;
    }

    public void SpawnObjectAtDefaultByIndex(int index)
    {
        SpawnObject(index, defaultSpawn, Quaternion.identity);
    }

    public void SpawnObject(int index, Vector3 coords, Quaternion rotation)
    {
        if (index >= objects.Count)
        {
            Debug.LogError("Index > objects.count");
            return;
        }

        if (objects[index] == null)
        {
            Debug.LogError("Object = null at given index");
            return;
        }

        Instantiate(objects[index], coords, rotation);
    }

    public void SpawnObjectByName(string name, Vector3 coords, Quaternion rotation)
    {
        GameObject objToSpawn;

        if ((objToSpawn = objects.Find(x => x.name == name)) == null)
        {
            Debug.LogError("Could not find object matching parameter name");
            return;
        }

        Instantiate(objToSpawn, coords, rotation);
    }
}
