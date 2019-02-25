using HoloToolkit.Unity.InputModule;
using HoloToolkit.Unity.SpatialMapping;
using UnityEngine;

public class HoldAnywhereHandler : MonoBehaviour, IHoldHandler
{
    /// <summary>
    /// Game object to send a fallback hold event to, using a custom "AnywhereHoldCompleted" event.
    /// </summary>
    public GameObject SendEventToObject;

    // Use this for initialization
    void Start()
    {
        Debug.Log(gameObject.name + " : Registering as fallback input handler.");
        // Register using the singleton input manager instance of the HoloToolkit 
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    public void OnHoldCompleted(HoldEventData eventData)
    {
        Debug.Log(gameObject.name + " : Received fallback OnHoldCompleted event. " + Time.time);
        if (SendEventToObject != null && SendEventToObject.GetComponent<TapToPlace>() != null)
        {
            // Send custom event to the registered game object
            var receivingObject = SendEventToObject.GetComponent<TapToPlace>();
            if (!receivingObject.IsBeingPlaced)
            {
                receivingObject.OnInputClicked(null);
            }
            //SendEventToObject.SendMessage("AnywhereHoldCompleted", null);
        }
    }

    public void OnHoldStarted(HoldEventData eventData)
    {
        // Implementation not needed, but method required from interface
    }

    public void OnHoldCanceled(HoldEventData eventData)
    {
        // Implementation not needed, but method required from interface
    }
}