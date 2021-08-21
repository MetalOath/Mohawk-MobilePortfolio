using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TouchDetectionTracker : MonoBehaviour
{
    [Header("Parameter")]
    public int trackedFingerID;
    [SerializeField]
    private TouchPhase currentTouchPhase = TouchPhase.Canceled;
    [Space, Header("UnityEvents")]
    public UnityEvent onBegan;
    public UnityEvent onMoved;
    public UnityEvent onStationary;
    public UnityEvent onEnded;
    public UnityEvent onCanceled;
    [System.Serializable]
    public class Vector3UnityEvent : UnityEvent<Vector3> { }
    public Vector3UnityEvent fingerScreenPosition;
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).fingerId == trackedFingerID)
            {
                Touch touch = Input.GetTouch(i);
                fingerScreenPosition?.Invoke(touch.position);
                if (currentTouchPhase != touch.phase)
                    ProcessPhase(touch.phase);
            }
        }
    }
    public void ProcessPhase(TouchPhase phase)
    {
        switch (phase)
        {
            case TouchPhase.Began:
                onBegan?.Invoke();
                break;
            case TouchPhase.Moved:
                onMoved?.Invoke();
                break;
            case TouchPhase.Stationary:
                onStationary?.Invoke();
                break;
            case TouchPhase.Ended:
                onEnded?.Invoke();
                break;
            case TouchPhase.Canceled:
                onCanceled?.Invoke();
                break;
        }
        currentTouchPhase = phase;
    }
}