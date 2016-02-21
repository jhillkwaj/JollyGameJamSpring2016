using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.DontDestroyOnLoad (this.gameObject);
		//Application.LoadLevel ("Level1");

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
