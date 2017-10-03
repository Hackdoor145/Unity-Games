using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    //velocidade de movimento do jogador
    public float velocidade;
    //pontos
    private int pontos;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Movimento do Jogador
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0,180,0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * velocidade * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //comeu?
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            pontos+=100;
            //Debug.Log(pontos);
        }
        else if (collision.gameObject.tag == "PowerFood")
        {
            Destroy(collision.gameObject);
            pontos += 500;
        }



    }
}
