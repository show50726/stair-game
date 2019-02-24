using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamSystemManager : MonoBehaviour {
    public int Stairs = 0;
    public int Score = 0;
    public PlayerMovement p;
    public Player pp;
    public GameObject GameOverText;
    public Text Restart;
    public Text StairShow;
    public Text score;
    public bool r;
    public bool p2 = false;
    public Text Quit;
    public bool q;
	// Use this for initialization
	void Start () {
        GameOverText.SetActive(false);
        Restart.enabled = false;
        r = false;
        Quit.enabled = false;
        q = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(r && Input.GetKeyDown(KeyCode.R))
        {
            p.canMove = true;
            p.transform.position = new Vector3(-0.01f, 9.31f, 0);
            pp.UpdateHealth(pp.maxHealth);
            Score = 0;
            Stairs = 0;
            score.text = "Score: " + 0;
            StairShow.text = "Stairs: " + 0;
            GameOverText.SetActive(false);
            Restart.enabled = false;
            r = false;
            Quit.enabled = false;
            q = false;
            FloorMove.speed = new Vector3(0, 0.03f, 0);
            FloorMove.speedup = 0;
        }
        if(q && Input.GetKeyDown(KeyCode.Q))
        {
            Application.LoadLevel(0);
        }
	}
    public void AddStair()
    {
        if (!r && !p2)
        {
            Stairs++;
            StairShow.text = "Stairs: " + Stairs;
        }
    }

    public void AddScore(int x)
    {
        if (!r && !p2)
        {
            Score += x;
            score.text = "Score: " + Score;
        }
    }

    public void GameOver()
    {
        if(Score > PlayerPrefs.GetInt("Score"))
        {
            PlayerPrefs.SetInt("Score", Score);
        }
        if (Stairs > PlayerPrefs.GetInt("Stairs"))
        {
            PlayerPrefs.SetInt("Stairs", Stairs);
        }
        PlayerPrefs.Save();
        r = true;
        q = true;
        Restart.enabled = true;
        Quit.enabled = true;
        p.canMove = false;
        GameOverText.SetActive(true);
    }
}
