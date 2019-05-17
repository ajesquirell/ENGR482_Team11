using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;
using HoloToolkit.Unity.UX;
using HoloToolkit.Unity.InputModule.Utilities.Interactions;
using UnityEngine.XR.WSA;

public class Lock : MonoBehaviour {

    public WorldAnchorManager worldAnchorManager;
    //private string savedAnchorName; //Only used at Start() to check if anchor exists, so we can enable the gameObject in the scene. If the user does not want the object in scene, they will "unlock" object (remove its worldanchor)
	// Use this for initialization
	void Start () {

        worldAnchorManager.AttachAnchor(gameObject); //Attempt to find anchor, and place object at that location

        //// Try to load a previously saved world anchor (Partly taken from WorldAnchorManager Code from Microsoft)
        //WorldAnchor savedAnchor = worldAnchorManager.AnchorStore.Load(string.Empty,this.gameObject);

        //if (savedAnchor != null) //If we have saved the location of this object, then show it in the scene and place in correct location
        //{
        //    this.gameObject.SetActive(true);
        //    worldAnchorManager.AttachAnchor(this.gameObject);
        //}

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

        worldAnchorManager.AttachAnchor(gameObject);
    }

    public void unlockRoot()
    {
        
        if (gameObject.GetComponent<HandDraggable>())
            gameObject.GetComponent<HandDraggable>().enabled = true;
        if (gameObject.GetComponent<BoundingBoxRig>())
            gameObject.GetComponent<BoundingBoxRig>().enabled = true;
        if (gameObject.GetComponent<TwoHandManipulatable>())
            gameObject.GetComponent<TwoHandManipulatable>().enabled = true;

        worldAnchorManager.RemoveAnchor(gameObject);
    }
}
