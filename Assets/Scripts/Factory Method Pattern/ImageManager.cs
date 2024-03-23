using UnityEngine;

public class ImageManager : MonoBehaviour
{
    private ImageFactory imageFactory;

    private void Start()
    {
        imageFactory = GetComponent<ImageFactory>();

        // Create color-changing images
        IColorChangingImage redImage = imageFactory.CreateImage("Red");
    }
}
