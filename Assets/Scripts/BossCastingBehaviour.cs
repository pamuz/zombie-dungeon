﻿using UnityEngine;
using System.Collections;

public class BossCastingBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("castMagic");
	}

	IEnumerable castMagic() {
		Debug.Log ("Casting magic");
		yield return new WaitForSeconds(3f);
	}
}