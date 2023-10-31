using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerText : MonoBehaviour {

	public GameObject bio;

	void Start () {
		bio.SetActive (false);
	}



	private void OnTriggerStay(Collider Other){
		bio.SetActive (true);
	}

	private void OnTriggerExit(Collider Other){
		bio.SetActive (false);
	}

}
