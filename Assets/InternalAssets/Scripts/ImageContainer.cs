using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageContainer : MonoBehaviour
{
    [SerializeField] Image image;
    [SerializeField] RectTransform rectTransform;
    [SerializeField] AspectRatioFitter aspectRatioFitter;

    public void InitializeImageContainer(Sprite sprite)
    {
        rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, Screen.height / 2);
        float ratio = (float)sprite.texture.width / sprite.texture.height;
        aspectRatioFitter.aspectRatio = ratio;
        image.sprite = sprite;
    }
}
