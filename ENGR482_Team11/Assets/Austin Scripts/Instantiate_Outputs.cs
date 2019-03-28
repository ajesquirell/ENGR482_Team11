using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;

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
            OpenOutputs();
        }
        else
        {
            CloseOutputs();
        }
    }


    //The following used for voice commands - one to only open, one to only close outputs - But still checks if object exists (active) so that we don't get multiple root holograms
    public void OpenOutputs()
    {
        if (!active && outputCollection != null)
        {
            //Transform location = Vector3.MoveTowards(transform.position, )
            instantiatedObj = Instantiate(outputCollection, transform.position, outputCollection.transform.rotation);
            active = true;

            //Orient object towards user - Only about y axis
            if (CameraCache.Main != null)
            {
                Vector3 directionToUser = CameraCache.Main.transform.position - transform.position; // Vector = User position - Object Position
                directionToUser.y = 0.0f; //Because we don't want to change y direction - want it to keep facing up
                
                // If we are right next to the camera the rotation is undefined (used in Billboard component, thought it might be useful here to avoid weird behavior)
                if (directionToUser.sqrMagnitude < 0.001f)
                {
                    return;
                }

                // Calculate and apply the rotation required to reorient the object
                instantiatedObj.transform.rotation = Quaternion.LookRotation(-directionToUser);
            }
        }
    }

    public void CloseOutputs()
    {
        if (active)
        {
            Destroy(instantiatedObj);
            active = false;
        }
    }

    

    

}
