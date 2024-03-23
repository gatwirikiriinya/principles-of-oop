using UnityEngine;
using UnityEngine.UI; // Add this line to import the UI namespace

public class RedImage : MonoBehaviour, IColorChangingImage
{
    private UnityEngine.UI.Image image; // Fully qualify Image class with its namespace

    private void Start()
    {
        image = GetComponent<UnityEngine.UI.Image>(); // Fully qualify Image class with its namespace
        ChangeColor();
    }

    public void ChangeColor()
    {
        if (image != null)
        {
            image.color = Color.red;
        }
    }
}
