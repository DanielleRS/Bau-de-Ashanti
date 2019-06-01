using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fadeImages : MonoBehaviour {
	[SerializeField]
	private Image livroAnim1 = null;
	[SerializeField]
	private Image livroAnim2 = null;
	[SerializeField]
	private Image livroAnim3 = null;
	[SerializeField]
	private Image livroAnim4 = null;


	// Use this for initialization
	void Start () {
		abreCanvasLivro ();
	}



	// Update is called once per frame
	void Update () {

	}

	public void abreCanvasLivro(){
		
			livroAnim1.color = new Color (1, 1, 1, 1);
			StartCoroutine (fadeLivro2 ());
			
	}

	IEnumerator fadeLivro2(){
		for(float x=1; x>0;x-=(float)0.01){
			livroAnim1.color = new Color (1, 1, 1, x);
			yield return null;
		}
		StartCoroutine (fadeLivro3 ());
	}
	IEnumerator fadeLivro3(){
		yield return new WaitForSeconds (2);
		for(float x=1; x>0; x-=(float)0.02){
			livroAnim2.color = new Color (1, 1, 1, x);
			yield return null;

		}
		yield return new WaitForSeconds (2);
		for(float x=1; x>0; x-=(float)0.02){
			livroAnim3.color = new Color (1, 1, 1, x);
			yield return null;

		}
		SceneManager.LoadScene ("MainMenu");
	}


}
