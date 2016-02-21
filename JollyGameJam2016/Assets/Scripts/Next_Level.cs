using UnityEngine;
using System.Collections;

public class Next_Level : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter");
        
       Application.LoadLevel(Application.loadedLevel + 1);
       Debug.Log("Next Level"); 
     
    }
}
