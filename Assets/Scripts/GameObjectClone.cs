using UnityEngine;
using System.Collections;

public class GameObjectClone : MonoBehaviour
{
    public GameObject[] floors = new GameObject[3];
    private GameObject Clone;
    float timer = 0;


    void Update()
    {
        timer += Time.deltaTime;
        if (FloorCreate.floorCreate)
        {
            int i = Random.Range(0, 6);
            float j = Random.Range(-4.8f, 3f);
            float posx = j;
            Vector3 pos = new Vector3(posx, -5.0f, -5);
            Quaternion rot = new Quaternion(0, 0, 0, 0);
            Clone = Instantiate(floors[i], pos, rot);
            Clone.AddComponent<FloorMove>();
            FloorCreate.floorCreate = false;
        }
        GameObject[] AllObj = FindObjectsOfType(typeof(GameObject)) as GameObject[];

    }
}
