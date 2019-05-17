using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class LockButtonScript : MonoBehaviour, IInputClickHandler{

    public GameObject ObjectToLock;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        ObjectToLock.GetComponent<Lock>().lockRoot();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
