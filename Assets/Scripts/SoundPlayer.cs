using UnityEngine;
using System.Collections;

public class SoundPlayer : MonoBehaviour
{
	[SerializeField]
	private AudioSource audio = null;
	public void play(){
		audio.Play ();
	}
}

