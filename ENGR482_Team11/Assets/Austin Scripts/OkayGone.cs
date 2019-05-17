using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;

public class OkayGone : MonoBehaviour, IInputClickHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DestroyObj()
    {
        Destroy(this.gameObject);
    }

    public void RemoveSurfaceMag()
    {
        if (gameObject.GetComponent<SolverSurfaceMagnetism>())
            gameObject.GetComponent<SolverSurfaceMagnetism>().enabled = false;
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        DestroyObj();
    }
}
