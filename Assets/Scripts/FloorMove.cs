using UnityEngine;
using System.Collections;

public class FloorMove : MonoBehaviour
{
    public GamSystemManager GSM;
    static public Vector3 speed;
    static public float speedup = 0;
    public bool p2 = false;
    public bool getpoint = false;

    private void Start()
    {
        speedup = 0;
        if (GameObject.Find("Rabbit")) p2 = true;
        GSM = GameObject.Find("GSM").GetComponent<GamSystemManager>();
    }

    void Update()
    {
        speedup += 1 / 500 * Time.deltaTime; 
        speed = new Vector3(0, 0.03f + speedup, 0);
        transform.position += speed;
    }

    private float floorTimer = 0;
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && gameObject.name == "move_floor(Clone)")
            collision.gameObject.transform.Translate(0.03f, 0, 0);
        else if (collision.gameObject.tag == "Player" && gameObject.name == "jump_floor(Clone)")
            collision.gameObject.transform.Translate(0, 0.1f, 0);
        else if (collision.gameObject.tag == "Player" && gameObject.name == "broken_floor(Clone)")
        {
            floorTimer += Time.deltaTime;
            if (floorTimer > 0.2f)
            {
                Destroy(gameObject);
                floorTimer = 0;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!p2 && GetComponent<FloorMove>().getpoint != true)
        {
            GSM.AddScore(1);
            GetComponent<FloorMove>().getpoint = true;
            GSM.AddStair();
        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "harmful_floor (Clone)")
        {
            collision.gameObject.GetComponent<Player>().UpdateHealth(collision.gameObject.GetComponent<Player>().health - 5);
        }
        if (collision.gameObject.tag == "Player" && gameObject.name == "healing_floor (Clone)")
        {
            collision.gameObject.GetComponent<Player>().UpdateHealth(collision.gameObject.GetComponent<Player>().health + 5);
        }

    }


}