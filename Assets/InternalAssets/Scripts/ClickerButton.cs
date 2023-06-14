using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickerButton : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI clickCountField;
    int clickCount = 0;
    int ClickCount
    {
        get => clickCount;
        set
        {
            clickCount = value;
            clickCountField.text = $"ClickCount: {clickCount}";
        }
    }
    public void Click() => ClickCount++;
}
