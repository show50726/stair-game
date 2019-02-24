using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {
    public int s;
    public Text hs;
    public int st;
    public Text hst;
    public bool rank = false;
    // Use this for initialization
    void Start () {
		
	}

    public void levelLoad(int x)
    {
        Application.LoadLevel(x);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
        if (rank)
        {
            s = PlayerPrefs.GetInt("Score");
            hs.text = s.ToString();
            st = PlayerPrefs.GetInt("Stairs");
            hst.text = st.ToString();
        }
    }
}
