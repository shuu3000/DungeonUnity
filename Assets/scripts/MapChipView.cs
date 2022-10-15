using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapChipView : MonoBehaviour
{
    [SerializeField]
    private Image _image = null;
    // Start is called before the first frame update
    public void SetmapImage(Sprite sprite)
    {
        _image.sprite = sprite;
    }
}
