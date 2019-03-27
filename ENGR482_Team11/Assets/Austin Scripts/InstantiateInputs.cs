using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InstantiateInputs : MonoBehaviour
{

    public GameObject outputCollection;
    private GameObject instantiatedInput;
    bool active = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    //The following commands do the same as above, but used for voice commands - one to only open, one to only close outputs
    public void OpenOutputs()
    {
        if (!active && outputCollection != null)
        {
            //Transform location = Vector3.MoveTowards(transform.position, )
            instantiatedInput = Instantiate(outputCollection, transform.position, outputCollection.transform.rotation);
            active = true;

            instantiatedInput.gameObject.transform.position =
                GazeManager.Instance.GazeOrigin +
                GazeManager.Instance.GazeNormal * 1.5f;
            //InstantiateOutputs();
        }
    }

    public void CloseOutputs()
    {
        if (active)
        {
            Destroy(instantiatedInput);
            active = false;
            //InstantiateOutputs();
        }
    }





}
