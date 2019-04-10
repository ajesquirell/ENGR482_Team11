using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

public class TestAnchorCube : MonoBehaviour {

	// Use this for initialization
	void Start () {
        WorldAnchorManager.Instance.AttachAnchor(this.gameObject, "testcube");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
