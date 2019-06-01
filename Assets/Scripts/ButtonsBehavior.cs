using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonsBehavior : MonoBehaviour {
	[SerializeField]
	private GameObject paraMusica = null;
	[SerializeField]
	private string musica = null;

	public void irPara(string name){
		SceneManager.LoadScene (name);
	}

	public void irParaMenu(string name){
		paraMusica.GetComponent<SongStoper> ().paraMusica (musica);
		SceneManager.LoadScene (name);
	}

	public void quit(){
		Application.Quit ();
	}

}
