using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ToggleButtonSprite : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> spriteList;
    int index;
    private UnityEngine.UI.Image image;

    void Start()
    {
        index = 0;
        image = gameObject.GetComponent<UnityEngine.UI.Image>();
    }

    public void ToggleButton()
    {
        index++;
        index %= spriteList.Count;
        image.sprite = spriteList[index];
    }
}
