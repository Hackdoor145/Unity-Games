using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float velocidade;
    public Rigidbody2D rb2D;

    // Use this for initialization
    void Start () {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimento do Jogador
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidade * Time.deltaTime;
            rb2D.MoveRotation(rb2D.rotation + velocidade * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidade * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidade * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidade * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bateu!");
        transform.position += new Vector3(0, 0, 0);
    }
}
