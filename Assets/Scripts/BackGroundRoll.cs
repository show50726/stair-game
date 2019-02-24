using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRoll : MonoBehaviour {

    public float speed = -0.1f;
    private void Start()
    {
        speed = -0.1f;
    }

    void Update()
    {
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(0, Time.time * speed)*Time.deltaTime;
    }
}
