using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity;

public class OkayGone : MonoBehaviour, IInputClickHandler {

    public GameObject AirTapHelper1;
    public GameObject AirTapHelper2;
    public GameObject AirTapHelper3;

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

    public void RemoveSurfaceMag() //Also enable the Air Tap Helpers
    {
        if (gameObject.GetComponent<SolverSurfaceMagnetism>())
            gameObject.GetComponent<SolverSurfaceMagnetism>().enabled = false;
        AirTapHelper1.SetActive(true);
        AirTapHelper2.SetActive(true);
        AirTapHelper3.SetActive(true);
    }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        DestroyObj();
    }
}
