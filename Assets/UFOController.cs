using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOController : MonoBehaviour {
    private Rigidbody2D myRigidBody = null;
    public float forceValue;
    public ScoreManager gameScoreManager;

	// Use this for initialization
	void Start () {
        myRigidBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        float forceValueTemp = forceValue;
        Vector2 force2D = Vector2.zero;

        if (Input.GetKey(KeyCode.Space))
        {
            forceValueTemp *= 5;
        }
        if (Input.GetKey(KeyCode.W)) {
            force2D.y += forceValueTemp;
        }
        if (Input.GetKey(KeyCode.A))
        {
            force2D.x -= forceValueTemp;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force2D.y -= forceValueTemp;
        }
        if (Input.GetKey(KeyCode.D))
        {
            force2D.x += forceValueTemp;
        }

        
        myRigidBody.AddForce(force2D);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        gameScoreManager.addScore(10);
    }
}
