using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moves_Ned : MonoBehaviour {

    private float  v;
    private Rigidbody2D PlayerRB;
    private Animator PlayerANIM;
    private int IdAnimation;



    public static int pont;
	public bool grounded;    
    public Collider2D Pe, Baixo;
    public float  ForceJump;
	public Transform groundcheck;
    public Text Num;


	// Use this for initialization
	void Start () {
        PlayerRB = GetComponent<Rigidbody2D>();
        PlayerANIM = GetComponent<Animator>();
        pont = 0;
        PlayerPrefs.SetInt("Pontuacao",pont);
    }

    void FixedUpdate()
    {
		grounded = Physics2D.OverlapCircle (groundcheck.position,0.02f);   
    }

    // Update is called once per frame
    void Update () {
        Num.text = pont.ToString();

        v = Input.GetAxisRaw("Vertical");

        if (v == 0)
        {
            IdAnimation = 0;
            Pe.enabled = true;
            Baixo.enabled = false;
        }
        else if(v<0)
        {
            IdAnimation = 2;

            Pe.enabled = false;
            Baixo.enabled = true;
        }

		if (Input.GetButtonDown("Jump") && grounded) {
            PlayerRB.AddForce(new Vector2(0,ForceJump));            
        }

		PlayerANIM.SetBool("Grounded", grounded);
        PlayerANIM.SetInteger("IdAnimation",IdAnimation);
        PlayerANIM.SetFloat("SpeedY",PlayerRB.velocity.y);
	}


    private void OnTriggerEnter2D()
    {
        PlayerPrefs.SetInt("Pontuacao",pont);
        if (pont>PlayerPrefs.GetInt("Record")) {
            PlayerPrefs.SetInt("Record", pont);
        }
        Application.LoadLevel("GameOver");

    }
}
