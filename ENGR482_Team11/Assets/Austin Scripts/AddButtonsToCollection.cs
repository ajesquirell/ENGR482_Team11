using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.Collections;
using HoloToolkit.Unity.Buttons;

public class AddButtonsToCollection : MonoBehaviour {
    public ObjectCollection Parent;
    //public GameObject ButtonPrefab;
    //public Transform RootHologramParent;

    private void OnEnable()
    {

        //if (Parent.transform.childCount > 0)
        //    return;
        //foreach (Transform child in RootHologramParent)
        ////for (int i = 0; i < RootHologramParent.transform.childCount; i++)
        //{
        //    GameObject newButton = Instantiate(ButtonPrefab, Parent.transform);
        //    newButton.GetComponent<CompoundButtonText>().Text = child.name;
        //}
        Parent.UpdateCollection();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
