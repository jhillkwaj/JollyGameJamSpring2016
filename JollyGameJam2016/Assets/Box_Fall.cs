using UnityEngine;
using System.Collections;

public class Box_Fall : MonoBehaviour {

    // Use this for initialization
    Vector3 spawnPos;
    float spawnTime = -1;
    bool active = true;
    bool reset = false;
    public bool notTrigger = false;
    void OnTriggerEnter(Collider other)
    {
        
        if (!notTrigger && active && other.tag == "Player" && spawnTime < 0)
        {
            this.gameObject.GetComponent<Box_Fall>().Drop();
            foreach (GameObject g in GameObject.FindGameObjectsWithTag("Respawn"))
            {
                if(Random.value < .3f)
                { g.gameObject.GetComponent<Box_Fall>().Drop(); }
               
            }
            spawnTime = 20;
        }
        
    }

    void Drop()
    {
        Debug.Log("Drop");
        if(active && spawnTime < 0)
        {
            active = false;
            spawnPos = this.transform.position;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
            spawnTime = 2;
            reset = true;
        }
    }


    void Update()
    {
        spawnTime -= Time.deltaTime;
        if (spawnTime <= 0 && Input.GetKeyDown(KeyCode.R) && reset)
        {
            reset = false;
            this.gameObject.isStatic = true;
            GameObject go = (GameObject)Instantiate(Resources.Load("Cube (11)"));
            go.transform.position = spawnPos;

        }
    }

}
