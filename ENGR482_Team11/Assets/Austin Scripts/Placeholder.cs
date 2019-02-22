using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity;

namespace HoloToolkit.Unity.InputModule
{
    public class Placeholder : MonoBehaviour, IInputClickHandler
    {

        public Transform prefab;

        // Use this for initialization
        void Start()
        {
            InputManager.Instance.PushFallbackInputHandler(this.gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnInputClicked(InputClickedEventData eventData)
        {
            //throw new System.NotImplementedException();
            Transform instance = Instantiate(this.prefab);

            instance.gameObject.transform.position =
                GazeManager.Instance.GazeOrigin +
                GazeManager.Instance.GazeNormal * 1.5f;
           // var tapToPlace = instance.gameObject.AddComponent<TapToPlace>();
        }
    }
}


