using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlarTela : MonoBehaviour {



	public void Jogo() {
        Application.LoadLevel("scene_1");
    }
    public void Selecao()
    {
        Application.LoadLevel("Select");
    }



}
