using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandGrabber : OVRGrabber
{
    //public float pinchTreshold = 0.7f;
    public Material Hand_Pinch;
    public Material Hands;
    protected override void Start()
    {
        base.Start();
        
    }

    public override void Update()
    {
        base.Update();
        CheckIndexPinch();
    }

    void CheckIndexPinch()
    {
        var hand = GetComponent<OVRHand>();
        bool isPinching = hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        //float ringFingerPinchStrength = hand.GetFingerPinchStrength(OVRHand.HandFinger.Ring);

        if (!m_grabbedObj && isPinching && m_grabCandidates.Count > 0)
        {
            GrabBegin();
        }
           
        else if (m_grabbedObj && !isPinching)
        {
            GrabEnd();
        }

    }
}
