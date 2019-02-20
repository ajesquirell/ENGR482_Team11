using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HoloToolkit.Unity.InputModule
{
    /// <summary>
    /// Working off of the NavigationRotateResponder.cs and GazeResponder.cs to make a script that rotates an object when gaze input is active
    /// </summary>
    public class IThinkThisWillWork : MonoBehaviour, IFocusable
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnFocusEnter()
        {
            for (int i = 0; i < defaultMaterials.Length; i++)
            {
                // Rotate object on Y-axis when gaze enters.
                
            }
        }

        public void OnFocusExit()
        {
            for (int i = 0; i < defaultMaterials.Length; i++)
            {
                // Remove highlight on material when gaze exits.
                
            }
        }
    }

}

