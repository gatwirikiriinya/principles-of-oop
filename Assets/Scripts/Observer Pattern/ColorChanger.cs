using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Image image;

    private void ChangeColor()
    {
        image.color = Color.red;
    }


    private void Start()
    {
        // Subscribe to the color change event from the EventCoordinator
        EventCoordinator.Instance.onColorChange.AddListener(ChangeColor);
    }

    private void OnDestroy()
    {
        // Unsubscribe from the color change event when the GameObject is destroyed
        if (EventCoordinator.Instance != null)
        {
            EventCoordinator.Instance.onColorChange.RemoveListener(ChangeColor);
        }
    }
}
