using UnityEngine;
using System.Collections;
using System;

public enum BackendServer {Pomelo};  


[Serializable]
public class GameSettings : ScriptableObject {

	[Header("Debug")]
	public bool debugMode;

	[Header("Server Engine")]
	public BackendServer serverEngine;
}