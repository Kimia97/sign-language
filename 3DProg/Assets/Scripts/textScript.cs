using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public class textScript : MonoBehaviour, IPointerEnterHandler , IPointerExitHandler, IPointerClickHandler{

    public GameObject door;
  
    Color mouseOverColor = Color.black;
    public Text text;
    Color originalColor;
    bool openDoor = false;

	// Use this for initialization
	void Start () {
        originalColor = text.color;
	}
	

    public void OnPointerEnter(PointerEventData eventData)
    {
        text.color = mouseOverColor;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        text.color = originalColor;
    }

    public void startGame()
    {
        openDoor = true;
    }

    void Update()
    {
        if(openDoor == true)
        {
            while(door.transform.localRotation.x < 90)
            {
                door.transform.Rotate(Time.deltaTime * 2, 0, 0);
            }
            
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        startGame();
    }
}
