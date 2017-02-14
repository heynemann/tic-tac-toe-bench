using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PomeloBackendServer : IBackend {
	public void OnSplashEnter () {}
	public void OnSplashExit () {}

	public string CreateUser () {
		return Guid.NewGuid ().ToString ();
	}
}
