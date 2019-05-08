﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class InstantiateInputs : MonoBehaviour, IInputClickHandler
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
