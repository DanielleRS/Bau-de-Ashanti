using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configuracoes : MonoBehaviour {
	[SerializeField]
	private GameObject canvasConfiguracoes = null;

	// Use this for initialization
	void Start () {
		canvasConfiguracoes.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void abrirConfiguracoes () {
		canvasConfiguracoes.SetActive (true);
	}
}
