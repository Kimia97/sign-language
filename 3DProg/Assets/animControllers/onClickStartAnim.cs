using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickStartAnim : MonoBehaviour {

    public AnimationClip animationClip;
    public Animator animator;



	// Use this for initialization
	void Start () {
        animator.SetBool("playH", true);
        Debug.Log("button pressed");
	}
	
	// Update is called once per frame
	void Update () {
        

    }
}
