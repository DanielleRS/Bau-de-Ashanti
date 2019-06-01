using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CanvasBehavior : MonoBehaviour
{
	[SerializeField]
	private GameObject canvas = null;
	[SerializeField]
	private bool exception = false;
	void Start ()
	{
		if (!exception) 
			canvas.SetActive (false);
		else
			canvas.SetActive (true);
	}
	
	public void Ativar(){
		canvas.SetActive (true);
	}

	public void Desativar(){
		canvas.SetActive (false);
	}
}

