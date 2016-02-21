using UnityEngine;
using System.Collections;

public class Destroy_Block : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Respawn")
        {
            Destroy(other.gameObject);
        }

    }
}
