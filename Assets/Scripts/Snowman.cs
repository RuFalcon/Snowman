using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snowman : MonoBehaviour
{
    [SerializeField] Text _nameText;
    [SerializeField] List<GameObject> _hats = new List<GameObject>();
    [SerializeField] List<Renderer> _snowmanRenderer;
   

    public void SetName(string name)
    {
        _nameText.text = name;
    }

    public void SetHeight(float value)
    {
        transform.localScale = new Vector3(transform.localScale.x, value, transform.localScale.z);
    }

    public void SetWidth(float value)
    {
        transform.localScale = new Vector3(value, transform.localScale.y, transform.localScale.z);
    }

    public void SetHat(int index)
    {
        for (int i = 0; i < _hats.Count; i++)
        {
            if (i == index)
            {
                _hats[i].SetActive(true);
            }
            else
            {
                _hats[i].SetActive(false);
            }
        }
    }

    public void SetMaterial(Material material)
    {
        for (int i = 0; i < _snowmanRenderer.Count; i++)
        {
            _snowmanRenderer[i].material = material;
        }
    }
}
