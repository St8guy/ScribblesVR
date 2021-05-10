using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupriseScript : MonoBehaviour
{

    private object[] gameObjects;
    // Start is called before the first frame update

    void Start()
    {
        gameObjects = GameObject.FindObjectsOfType(typeof(GameObject));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        launch(col);
    }

    void launch(Collision col)
    {
        foreach (object o in gameObjects)
        {
            GameObject gobj = (GameObject)o;
            if (gobj.GetComponent<Rigidbody>() != null)
            {
                // See ya!
                float x = Random.Range(20.0f, 200.0f);
                float y = Random.Range(20.0f, 200.0f);
                float z = Random.Range(20.0f, 200.0f);
                gobj.GetComponent<Rigidbody>().AddForce(x, y, z);
            }
        }
    }
}
