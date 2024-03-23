using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void Start()
    {
        // Trigger the color change event from the EventCoordinator
        EventCoordinator.Instance.TriggerColorChange();
    }
}
