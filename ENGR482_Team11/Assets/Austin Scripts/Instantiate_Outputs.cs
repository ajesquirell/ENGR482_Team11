using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class Instantiate_Outputs : MonoBehaviour, IInputClickHandler {

    public GameObject outputCollection;
    private GameObject instantiatedObj;
    bool active = false;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Debug.Log("Input: Pressed");

        if (!active && outputCollection != null)
        {
            instantiatedObj = Instantiate(outputCollection, transform.position, outputCollection.transform.rotation);
            active = true;
        }
        else
        {
            Destroy(instantiatedObj);
            //Destroy(instantiatedObj.GetComponentsInChildren();
            active = false;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
