using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	Renderer [] rn;
	void Start () {

		rn = gameObject.GetComponentsInChildren<Renderer> ();
	}

	public void Red(){

		rn [0].material.color = Color.red;
	}

	public void Blue(){

		rn [0].material.color = Color.blue;
	}

	public void White(){

		rn [0].material.color = Color.white;
	}

	public void Black(){

		rn [0].material.color = Color.black;

	}
}

