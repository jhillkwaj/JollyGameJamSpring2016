using UnityEngine;
using System.Collections;

public class Next_Level : MonoBehaviour {
    public bool alt = false;
    void OnTriggerEnter(Collider other)
    {
        if(!alt)
            Application.LoadLevel(Application.loadedLevel + 1);
        else if(other.tag == "Player")
        {
            Destroy(this.gameObject.transform.parent.gameObject);
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Respawn"))
            { Destroy(g.gameObject); }
        }
     
    }
}
