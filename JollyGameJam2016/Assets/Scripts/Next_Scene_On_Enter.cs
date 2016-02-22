using UnityEngine;
using System.Collections;

public class Next_Scene_On_Enter : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel(Application.loadedLevel + 1);
        }
	}
}
