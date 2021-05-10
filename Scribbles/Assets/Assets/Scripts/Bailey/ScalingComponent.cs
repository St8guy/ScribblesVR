using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScalingComponent : MonoBehaviour
{
    public static List<GameObject> scalingList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnCollisionEnter(Collision col)
    {
        scalingList.Add(col.gameObject);
    }

    void OnCollisionExit(Collision col)
    {
        scalingList.Remove(col.gameObject);
    }

}
