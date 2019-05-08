using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;
using HoloToolkit.Unity.UX;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;

public class Lock : MonoBehaviour {

    public WorldAnchorManager worldAnchorManager;
	// Use this for initialization
	void Start () {
        worldAnchorManager.AttachAnchor(this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void lockRoot()
    {
        //Simply disable the components that we use to move
        if (gameObject.GetComponent<HandDraggable>())
            gameObject.GetComponent<HandDraggable>().enabled = false;
        if (gameObject.GetComponent<BoundingBoxRig>())
            gameObject.GetComponent<BoundingBoxRig>().enabled = false;
        if (gameObject.GetComponent<TwoHandManipulatable>())
            gameObject.GetComponent<TwoHandManipulatable>().enabled = false;

        worldAnchorManager.AttachAnchor(this.gameObject);
    }

    public void unlockRoot()
    {
        
        if (gameObject.GetComponent<HandDraggable>())
            gameObject.GetComponent<HandDraggable>().enabled = true;
        //if (gameObject.GetComponent<BoundingBoxRig>())
        //    gameObject.GetComponent<BoundingBoxRig>().enabled = true;
        if (gameObject.GetComponent<TwoHandManipulatable>())
            gameObject.GetComponent<TwoHandManipulatable>().enabled = true;

        worldAnchorManager.RemoveAnchor(this.gameObject);
    }
}
