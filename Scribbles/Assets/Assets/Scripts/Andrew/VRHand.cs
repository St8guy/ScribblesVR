using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class VRHand
{
    public OVRHand _Hand;
    public bool _IndexPinched;
    public bool _MiddlePinched;
    public bool _RingPinched;
    public bool _PinkyPinched;
    public Vector3 _Position;
    public Vector3 _Scale;
    public Quaternion _Rotation;

    public VRHand(OVRGrabber obj)
    {
        _Hand = obj.GetComponent<OVRHand>();
        _IndexPinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Index);
        _MiddlePinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Middle);
        _RingPinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Ring);
        _PinkyPinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Pinky);
        _Position = _Hand.transform.position;
        _Scale = _Hand.transform.localScale;
        _Rotation = _Hand.transform.rotation;
    }

    public OVRHand Hand
    {
        get => _Hand;
    }

    public bool IndexPinched
    {
        get { _IndexPinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Index); return _IndexPinched; }
    }

    public bool MiddlePinched
    {
        get { _MiddlePinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Middle); return _MiddlePinched; }
    }

    public bool RingPinched
    {
        get { _RingPinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Ring); return _RingPinched; }
    }

    public bool PinkyPinched
    {
        get { _PinkyPinched = _Hand.GetFingerIsPinching(OVRHand.HandFinger.Pinky); return _PinkyPinched; }
    }

    public Vector3 Position
    {
        get { _Position = _Hand.transform.position; return _Position; }
    }

    public Vector3 Scale
    {
        get { _Scale = _Hand.transform.localScale; return _Scale; }
    }

    public Quaternion Rotation
    {
        get { _Rotation = _Hand.transform.rotation; return _Rotation; }
    }

}
