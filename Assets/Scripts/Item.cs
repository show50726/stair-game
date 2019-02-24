using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public GamSystemManager GSM;
    public AudioSource a;
    public bool p2 = false;
	// Use this for initialization
	void Start () {
        if (GameObject.Find("Rabbit")) p2 = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(!p2)
                GSM.AddScore(10);
            a.Play();
            Destroy(gameObject, 0.1f);
        }
    }
}
