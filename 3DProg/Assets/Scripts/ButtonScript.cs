using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

    private Image image;
    public Button btn;

    private void Start()
    {
        image = GameObject.FindGameObjectWithTag("showImage").GetComponent<Image>() as Image;
        btn.onClick.AddListener(changeImage);
    }

    public void changeImage()
    {
        Sprite sprite = btn.image.sprite;
        image.sprite = sprite;
    }
    
}
