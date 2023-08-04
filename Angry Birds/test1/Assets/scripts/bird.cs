using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour {
	private bool isclick = false;

	private void OnMouseDown() { //按下
		isclick =true;
	}

	private void OnMouseUp() {  //抬起
		isclick =false;
	}
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	private void Update () {
		if (isclick) {
			
		}
	}
}
