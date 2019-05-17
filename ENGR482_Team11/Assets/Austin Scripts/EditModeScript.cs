using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditModeScript : MonoBehaviour {

    public GameObject EditModeMenu;
    public GameObject EditSpeechManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnterEditMode()
    {
        EditModeMenu.SetActive(true);
        EditSpeechManager.SetActive(true);
    }

    public void ExitEditMode()
    {
        EditModeMenu.SetActive(false);
        EditSpeechManager.SetActive(false);
    }
}
