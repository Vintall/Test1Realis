using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollViewLoader : MonoBehaviour
{
    [SerializeField] GameObject imageContainer;
    [SerializeField] List<Sprite> sprites;
    [SerializeField] Transform content;

    private void Start()
    {
        foreach (Sprite sprite in sprites)
        {
            GameObject newObj = Instantiate(imageContainer);
            ImageContainer imageContainerObj = newObj.GetComponent<ImageContainer>();

            newObj.transform.SetParent(content);
            imageContainerObj.InitializeImageContainer(sprite);
        }
    }
}
