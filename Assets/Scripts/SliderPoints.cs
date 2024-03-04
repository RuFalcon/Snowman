using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderPoints : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text _pointsText;
    public void SetValue(float value)
    {
        _pointsText.text = value.ToString("0.0");
    }
}
