using UnityEngine;
using System.Collections;

// Attach this to a gameobject that exists in the initial scene
public class Backend : MonoBehaviour {

	[SerializeField]
	public static IBackend b; 
	public static Backend instance;

	void Start(){
		DontDestroyOnLoad(gameObject);
		if(Backend.instance == null){
			Backend.instance = this;
		} else {
			Debug.LogWarning("A previously awakened Backend MonoBehaviour exists!", gameObject);
		}

		if(Backend.b == null){
			Backend.b = LoadBackend();
		}
	}

	IBackend LoadBackend() {
		if (Settings.s.serverEngine == BackendServer.Pomelo) {
			return new PomeloBackendServer ();
		}
		return null;
	}
}