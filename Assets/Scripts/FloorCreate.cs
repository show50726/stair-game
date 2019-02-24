using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCreate : MonoBehaviour {
    static public bool floorCreate = true;
    // Use this for initialization
    void Start () {
        floorCreate = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Floor")
            floorCreate = true;
    }

}
