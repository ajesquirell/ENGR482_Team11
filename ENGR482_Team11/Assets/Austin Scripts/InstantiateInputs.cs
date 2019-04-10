using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InstantiateInputs : MonoBehaviour
{

    public GameObject rootHologram;
    public bool active = false; //Meaning root hologram this goes along with shouldn't be in the scene

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
        if (!active)
        {
            rootHologram.SetActive(true);
            active = true;

            rootHologram.transform.position =
                GazeManager.Instance.GazeOrigin +
                GazeManager.Instance.GazeNormal * 1.5f;
        }
    }

    public void CloseOutputs()
    {
        if (active)
        {
            // Destroy(instantiatedInput);
            rootHologram.SetActive(false);
            active = false;
        }
    }





}
