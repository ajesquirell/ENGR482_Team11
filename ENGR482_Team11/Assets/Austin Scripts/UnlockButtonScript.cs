using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class UnlockButtonScript : MonoBehaviour, IInputClickHandler{

    public GameObject ObjectToUnlock;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        ObjectToUnlock.GetComponent<Lock>().unlockRoot();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
