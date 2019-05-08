using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

public class AnchorScript : MonoBehaviour
{

    public WorldAnchorManager worldAnchorManager;

    /// <remarks>The name component/data member of this gameobject will be used as the anchor id to attach to. If you pass a game object that does not have a world anchor, it will make a new anchor under the name of that GameObject, but attach this.gameObject to it. (I think-I'm writing this beforehand lol)</remarks>
    [Tooltip("Allows you to attach to an existing anchor of another object. Leave NULL or empty or whatever if you want to create a new anchor under the name of this gameobject.")]
    public GameObject GameObjectToAttachAnchorTo;

    // Use this for initialization
    void Start()
    {
        AnchorIt(); //Will load anchor from anchor store
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AnchorIt() 
    {
        MoveParentToChild();

        worldAnchorManager.AttachAnchor(this.gameObject);

        if (this.gameObject.GetComponent<Renderer>() != null)
            this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        if (this.gameObject.GetComponentInChildren<Renderer>() != null)
            this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.red;
        if (this.gameObject.GetComponentInParent<Renderer>() != null)
            this.gameObject.GetComponentInParent<Renderer>().material.color = Color.red;
    }

    public void ReleaseAnchor() //Use by root and output, whether you do AnchorIt() or AttachToAnchor()
    {
        worldAnchorManager.RemoveAnchor(this.gameObject);
        if (this.gameObject.GetComponent<Renderer>() != null)
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
        if (this.gameObject.GetComponentInChildren<Renderer>() != null)
            this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.green;
        if (this.gameObject.GetComponentInParent<Renderer>() != null)
            this.gameObject.GetComponentInParent<Renderer>().material.color = Color.green;
    }
    
    public void AttachToAnchor() 
    {   
        worldAnchorManager.AttachAnchor(this.gameObject, GameObjectToAttachAnchorTo.name); //We want to access the "Load" Unity function of the WorldAnchorStore, 
        this.gameObject.GetComponentInChildren<Renderer>().material.color = Color.blue;    //which we can access directly from the worldAnchorManager, but AttachAnchor() actually does this itself nicely
                                                                                           //Sadly there is no function (I don't think) that just unattaches an object from an anchor, all the WorldAnchorManager and WorldAnchorStore
                                                                                           //API functions end up removing the anchor from the store
    }

    public void MoveParentToChild()
    {
        //Empty parent transform to move to location of child(visible hologram) so we can update the anchor to where we moved the actual hologram
        this.gameObject.transform.position = new Vector3(0, 0, 0);
    }


}
