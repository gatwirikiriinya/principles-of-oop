using System;
using UnityEngine;

public class ImageFactory : MonoBehaviour
{
    public IColorChangingImage CreateImage(string imageType)
    {
        switch (imageType)
        {
            case "Red":
                return new RedImage();
            // Add cases for other image types as needed
            default:
                throw new ArgumentException("Invalid image type");
        }
    }
}
