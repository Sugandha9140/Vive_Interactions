using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VR_Debug : MonoBehaviour {

	public TextMeshPro tmp;
	// Use this for initialization
	void Start () {
		//tmp = GameObject.FindGameObjectWithTag ("textMeshProDebug").GetComponent<TextMeshPro> ();
	}

	public void Print_VR(string message){
		tmp.text = tmp.text + "\n" + message;
	}
	// Update is called once per frame
	void Update () {
		
	}
}
