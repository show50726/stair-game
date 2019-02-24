using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GSM2P : MonoBehaviour {
    public PlayerMovement mp1;
    public Movement2P mp2;
    public Player p1;
    public Player p2;
    public GameObject GameOverText;
    public Text Restart;
    public bool r;
    public Text Quit;
    public bool q;
    // Use this for initialization
    void Start()
    {
        GameOverText.SetActive(false);
        Restart.enabled = false;
        r = false;
        Quit.enabled = false;
        q = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (r && Input.GetKeyDown(KeyCode.R))
        {
            mp1.canMove = true;
            mp2.canMove = true;
            mp1.transform.position = new Vector3(2.29f, 8.68f, 0);
            mp2.transform.position = new Vector3(-2, 8.65f , 0);
            p1.UpdateHealth(p1.maxHealth);
            p2.UpdateHealth(p2.maxHealth);
            GameOverText.SetActive(false);
            Restart.enabled = false;
            r = false;
            Quit.enabled = false;
            q = false;
            FloorMove.speed = new Vector3(0, 0.03f, 0);
            FloorMove.speedup = 0;
        }
        if (q && Input.GetKeyDown(KeyCode.Q))
        {
            Application.LoadLevel(0);
        }
    }

    public void GameOver()
    {
        r = true;
        q = true;
        Restart.enabled = true;
        Quit.enabled = true;
        mp1.canMove = false;
        mp2.canMove = false;
        if (p1.health <= 0 && p2.health > 0)
            GameOverText.GetComponent<Text>().text = "Rabbit Win";
        else if(p1.health > 0 && p2.health <= 0)
            GameOverText.GetComponent<Text>().text = "Player Win";
        else
            GameOverText.GetComponent<Text>().text = "Game Over";
        GameOverText.SetActive(true);
    }
}
