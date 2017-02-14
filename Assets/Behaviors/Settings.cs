using UnityEngine;
using System.Collections;

// Attach this to a gameobject that exists in the initial scene
public class Settings : MonoBehaviour {
	
	[Tooltip("Choose which GameSettings asset to use")]
	public GameSettings _settings; // drag GameSettings asset here in inspector

	[SerializeField]
	public static GameSettings s; 
	public static Settings instance;

	void Awake(){
		DontDestroyOnLoad(gameObject);
		EnsureSettings ();
	}

	public void EnsureSettings() {
		if(Settings.instance == null){
			Settings.instance = this;
		}

		if(Settings.s == null){
			Settings.s = _settings;
		}
	}
}