using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBackend {
	void OnSplashEnter ();
	void OnSplashExit ();
	string CreateUser ();
}
