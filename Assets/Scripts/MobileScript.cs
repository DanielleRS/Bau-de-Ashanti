using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void abreTeclado() {
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, true);
	}
}
