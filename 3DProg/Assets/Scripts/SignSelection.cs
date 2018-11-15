using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  SignSelection: MonoBehaviour
{

    private GameObject[] signList;
    private int index;

    private void Start()
    {
        signList = new GameObject[transform.childCount];


        // Fill array with models
        for (int i = 0; i < transform.childCount; i++)
        {
            signList[i] = transform.GetChild(i).gameObject;
        }

        // Disable them from view.
        foreach (GameObject go in signList)
        {
            go.SetActive(false);
        }

        //Toggle on first index

        if (signList[0])
        {
            signList[0].SetActive(true);
        }
    }



    //
    public void Toggle(int index)
    {

        for (int i = 0; i < signList.Length; i++)
        {
            signList[i].SetActive(index == i);
        }
    }
}
