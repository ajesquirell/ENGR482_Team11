using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InstantiateInputs : MonoBehaviour, IInputClickHandler
{

    public GameObject rootHologram;
    public bool active;

    // Use this for initialization
    void Start()
    {
        active = this.gameObject.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OpenInputs()
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

    public void CloseInputs()
    {
        if (active)
        {
            // Destroy(instantiatedInput);
            rootHologram.SetActive(false);
            active = false;
        }
    }

    public void ToggleInputs()
    {
        if (!active)
        {
            OpenInputs();
        }
        else
        {
            CloseInputs();
        }
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        ToggleInputs();
    }
}
