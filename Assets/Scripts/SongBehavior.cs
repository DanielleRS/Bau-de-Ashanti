using UnityEngine;
using System.Collections;

public class SongBehavior : MonoBehaviour
{
	void Awake(){
		DontDestroyOnLoad(this.gameObject);
	}

	public void Stop(){
		Destroy (this.gameObject);
	}

}

