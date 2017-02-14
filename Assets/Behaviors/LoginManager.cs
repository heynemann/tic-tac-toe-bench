using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.Unity;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour {
	void Awake() {

	}

	void Start() {
		if (PlayerPrefs.GetString ("userId") == "") {
			var userId = Backend.b.CreateUser ();
			PlayerPrefs.SetString ("userId", userId);
		}
		GoToMain ();
	}

	void GoToMain() {
		SceneManager.LoadScene ("Main");
	}
}
