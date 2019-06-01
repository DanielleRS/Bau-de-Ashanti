using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MapaBehavior : MonoBehaviour
{
	[SerializeField]
	private GameObject bauButton = null;
	[SerializeField]
	private GameObject database = null;
	[SerializeField] 
	GameObject chave1 = null;
	[SerializeField] 
	GameObject chave2 = null;
	[SerializeField] 
	GameObject chave3 = null;
	[SerializeField]
	GameObject canvasVitoriaHandler = null;

	[SerializeField]
	private Text tempo1 = null;
	[SerializeField]
	private Text tempo2 = null;
	[SerializeField]
	private Text tempo3 = null;
	[SerializeField]
	private Text moedas = null;
	// Use this for initialization
	void Start ()
	{
		database.GetComponent<DatabaseBehavior> ().checaChaves (chave1, chave2, chave3, bauButton,canvasVitoriaHandler);
		database.GetComponent<DatabaseBehavior> ().checaTempos (tempo1, tempo2, tempo3);
		database.GetComponent<DatabaseBehavior> ().checaMoedas (moedas);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

