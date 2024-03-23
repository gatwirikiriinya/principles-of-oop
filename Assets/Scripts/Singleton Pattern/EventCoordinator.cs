using UnityEngine;
using UnityEngine.Events;

public class EventCoordinator : MonoBehaviour
{
    // Static reference to the instance of the EventCoordinator
    private static EventCoordinator instance;

    // Public property to access the EventCoordinator instance
    public static EventCoordinator Instance
    {
        get
        {
            // If the instance doesn't exist, find it in the scene or create a new one
            if (instance == null)
            {
                instance = FindObjectOfType<EventCoordinator>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("EventCoordinator");
                    instance = obj.AddComponent<EventCoordinator>();
                }
            }
            return instance;
        }
    }

    // UnityEvent for color change event
    public UnityEvent onColorChange;

    // Method to trigger color change event
    public void TriggerColorChange()
    {
        onColorChange.Invoke();
    }

    // Ensure the EventCoordinator is not destroyed when loading new scenes
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
