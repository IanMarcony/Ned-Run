using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawncontroller : MonoBehaviour {

	public GameObject obsf,plat;
	public float times,posa,posb;//Times, é a quantidade de segundos para spwanar outro objeto

	private int pos,n;
	private float y,atual;

	// Use this for initialization
	void Start () {
		atual = 0;//Zera contador de segundos

	}
	
	// Update is called once per frame
	void Update () {
		n = Random.Range (1,100);//Números aleatórios
		if (n < 50) {
			atual += Time.deltaTime;//Soma um segundo

			if (atual >= times) {
				atual = 0;
				pos = Random.Range (1, 100);
				if (pos > 50) {
					y = posa;

				} else {
					y = posb;
				}
			
				GameObject tempfab = Instantiate (obsf) as GameObject;
				tempfab.transform.position = new Vector3 (transform.position.x, y);
			}			
		} else {
			atual += Time.deltaTime;

			if (atual >= times) {
				atual = 0;
				pos = Random.Range (1, 100);
				if (pos > 50) {
					y = posa;

				} else {
					y = posb;
				}

				GameObject tempfab = Instantiate (plat) as GameObject;
				tempfab.transform.position = new Vector3 (transform.position.x, y);
			}
		}

	}
}
