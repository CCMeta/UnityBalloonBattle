﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Trap_Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Player"){
			SceneManager.LoadScene ("S4");
		}
	}
}
