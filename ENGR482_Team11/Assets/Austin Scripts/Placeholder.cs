﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;


//namespace HoloToolkit.Unity.InputModule
//{
    public class Placeholder : MonoBehaviour, IInputClickHandler
    {

        public Transform prefab1;
        public Transform prefab2;
        public Transform prefab3;
        public Transform prefab4;

    public void OnInputClicked(InputClickedEventData eventData)
    {
        Transform instance = Instantiate(this.prefab1);

        instance.gameObject.transform.position =
            GazeManager.Instance.GazeOrigin +
            GazeManager.Instance.GazeNormal * 1.5f;
    }

    // Use this for initialization
    private void Start()
        {
            InputManager.Instance.PushFallbackInputHandler(this.gameObject);
        }

        // Update is called once per frame
        private void Update()
        {
            //if (!this.loaded && (WorldAnchorManager.Instance.AnchorStore != null))
            //{
              //  var ids = WorldAnchorManager.Instance.AnchorStore.GetAllIds();

                //NB: I'm assuming that the order here is either preserved or maybe doesn't matter.
              //  foreach (var id in ids)
               // {
                 var instance = Instantiate(this.prefab1);
               //  WorldAnchorManager.Instance.AttachAnchor(instance.gameObject, id);
               // }
                //this.loaded = true;
            }
        }
         // bool loaded;
//}


