using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento1 : MonoBehaviour {

	public float speed;
	private float x;
	private  GameObject player;
    private bool pontuado;



	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Ned") as GameObject;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		x = transform.position.x;

		x += speed*Time.deltaTime*-1;

		transform.position = new Vector3 (x,transform.position.y);

		if (x <= -3.5) {
			Destroy (transform.gameObject);
		}
		if (x<player.transform.position.x&&!pontuado) {
			Moves_Ned.pont++;
			pontuado = true;
        }
		switch(Moves_Ned.pont){
		case 15:
			speed += 0.05f;

			break;
		case 20:
			speed += 0.05f;

			break;
		case 29:
			speed += 0.05f;

			break;
		case 35:
			speed += 0.05f;
		
			break;

		case 40:
			speed += 0.05f;
	
			break;
		case 50:
			speed += 0.05f;
	
			break;
		case 58:
			speed += 0.05f;
			break;
		}

		
	}
}
