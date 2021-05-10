using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public static Spawn physicsButton;
    public List<GameObject> objects = new List<GameObject>();
    public int spawn = 0;
    void Start()
    {
        physicsButton = this;
    }

    void OnCollisionEnter(Collision collide)
    {
        if (collide.collider.gameObject.name == "Button")
        {
            Vector3 location = new Vector3(this.transform.position.x - .4f, this.transform.position.y + .3f, this.transform.position.z);
            SpawnObjectByName(objects[spawn].name, location, this.transform.rotation);
        }
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