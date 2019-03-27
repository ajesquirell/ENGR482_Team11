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
        InstantiateOutputs();
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //Toggle outputs - used for clicking
    public void InstantiateOutputs()
    {
        if (!active && outputCollection != null)
        {
            //instantiatedObj = Instantiate(outputCollection, transform.position, outputCollection.transform.rotation);
            //active = true;
            OpenOutputs();
        }
        else
        {
            //Destroy(instantiatedObj);
            //active = false;
            CloseOutputs();
        }
    }


    //The following commands do the same as above, but used for voice commands - one to only open, one to only close outputs
    public void OpenOutputs()
    {
        if (!active && outputCollection != null)
        {
            //Transform location = Vector3.MoveTowards(transform.position, )
            instantiatedObj = Instantiate(outputCollection, transform.position, outputCollection.transform.rotation);
            active = true;
            //InstantiateOutputs();
        }
    }

    public void CloseOutputs()
    {
        if (active)
        {
            Destroy(instantiatedObj);
            active = false;
            //InstantiateOutputs();
        }
    }

    

    

}
