using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text Pontuacao, Recorde;
    public int Rd;

	// Use this for initialization
	void Start () {
        Pontuacao.text = PlayerPrefs.GetInt("Pontuacao").ToString();
        Recorde.text = PlayerPrefs.GetInt("Record").ToString();
        Rd= PlayerPrefs.GetInt("Record");
    }
	
}
