using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public int health = 100;
    public int maxHealth = 100;
    public SimpleHealthBar hb;
    public GameObject GSM;
    bool ok = false;
    // Use this for initialization
    void Start () {
	
	}


    // Update is called once per frame
    public void UpdateHealth(int hp)
    {
        ok = GSM.GetComponent<GamSystemManager>() ? GSM.GetComponent<GamSystemManager>().r : GSM.GetComponent<GSM2P>().r;
        if (hp > 0 && hp < maxHealth && !ok)
        {
            health = hp;
            hb.UpdateBar(health, maxHealth);
        }
        else if(hp == maxHealth)
        {
            health = hp;
            hb.UpdateBar(health, maxHealth);
        }
        else if(hp <= 0)
        {
            health = 0;
            hb.UpdateBar(0, maxHealth);
            Dead ();
        }
        Debug.Log("Now " + gameObject.name + "'s HP is " + health);

    }

    public bool isDeath()
    {
        if (health <= 0) return true;
        return false;
    }
    public void Dead()
    {
        if(GSM.GetComponent<GamSystemManager>()) GSM.GetComponent<GamSystemManager>().GameOver();
        else GSM.GetComponent<GSM2P>().GameOver();
    }
}
