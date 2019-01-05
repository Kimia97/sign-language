using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class EventScripts : MonoBehaviour {

    public Image image;

    public void changeImage(Button btn) {
        Sprite sprite = btn.image.sprite;
        image.sprite = sprite;
    }

    public void exitApplication()
    {
        Application.Quit();
    }

}
