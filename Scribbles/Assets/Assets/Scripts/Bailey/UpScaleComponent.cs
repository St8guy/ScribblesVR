using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpScaleComponent : MonoBehaviour
{
    private Vector3 scalingAmount;

    // Start is called before the first frame update
    void Start()
    {
        scalingAmount = new Vector3(.2f, .2f, .2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScaleUp()
    {
        foreach (GameObject gobj in ScalingComponent.scalingList)
        {
            gobj.transform.localScale += scalingAmount;
        }
    }

    void OnCollisionEnter(Collision collide)
    {
        ScaleUp();
    }

}
