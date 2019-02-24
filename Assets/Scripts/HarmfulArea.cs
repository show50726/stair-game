using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmfulArea : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Floor")
            Destroy(collider.gameObject);
        if (collider.tag == "Player")
            collider.GetComponent<Player>().UpdateHealth(collider.GetComponent<Player>().health - 20);

    }

}
