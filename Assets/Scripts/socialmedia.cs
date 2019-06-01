using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class socialmedia : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void paginaFacebook() {
		Application.ExternalEval("window.open(\"https://www.facebook.com/projetosapufop/\",\"_blank\")");
	}

	public void paginaInstagram() {
		Application.ExternalEval("window.open(\"https://www.instagram.com/projetosap/\",\"_blank\")");
	}
	public void paginaSite() {
		Application.OpenURL( "http://projetosap.ufop.br" );
	}

}
