using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    Image buttonImage;

    private void Awake() => buttonImage = GetComponent<Image>();
    public void ChangeColor() => buttonImage.color = new Color(Random.value, Random.value, Random.value);
}
