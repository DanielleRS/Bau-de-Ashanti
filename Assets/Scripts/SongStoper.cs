using UnityEngine;
using System.Collections;

public class SongStoper : MonoBehaviour
{

	public void paraMusica(string id){
		GameObject m = GameObject.FindGameObjectWithTag (id);
		if (m!=null) {
			m.SendMessage ("Stop");
		}
	}
}

