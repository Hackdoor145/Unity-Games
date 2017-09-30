using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    public Transform playerPosition;

        //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log(playerPosition.position.x);
            rb2d.AddForce(new Vector2(1, 0));
        }
	}
}
