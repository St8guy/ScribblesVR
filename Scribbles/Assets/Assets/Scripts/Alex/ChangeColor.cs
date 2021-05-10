using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Material material;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Grabbable")
        {
            col.GetComponent<Renderer>().material = material;

            //Check syntax, might have to use a normal [] array idk been a while since i did this
            Renderer[] objList = col.gameObject.GetComponentsInChildren<Renderer>();

            foreach (Renderer rend in objList)
            {
                //change the material here
                rend.material = material;
            }
        }
    }
}