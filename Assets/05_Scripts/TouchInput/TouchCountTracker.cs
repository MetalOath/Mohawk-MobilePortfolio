using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TouchCountTracker : MonoBehaviour
{
    [System.Serializable]
    public class StringUnityEvent : UnityEvent<string> { }
    public StringUnityEvent updateText;

    void Update()
    {
        updateText?.Invoke("FingerCount: " + Input.touchCount.ToString());
    }
}
