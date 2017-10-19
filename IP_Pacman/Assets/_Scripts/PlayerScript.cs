using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    //playerSpeed de movimento do jogador
    public float playerSpeed;
    //score
    private int score;
    //direction N-norte, S-sul, O-oeste, E-este
    private char direction = 'O';
    //position of the player at the moment
    private Vector3 playerPosition;
    //referencia ao script gameManager
    public GameManager gameManager;

    int positionX;
    int positionY;

    private enum State
    {
        Dead,
        Alive
    }

    private enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }

    // Use this for initialization
    void Start()
    {
        playerPosition = gameObject.transform.position;
        
    }

    // Update is called once per frame
    private void Update()
    {
        //movimento automático, apenas se escolhe a direção
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameManager.IsEmptyPosition(positionX, positionY);
            direction = 'O';

        }

        if (Input.GetKey(KeyCode.RightArrow))   
        {
            //podeAndar = true;
            direction = 'E';
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //podeAndar = true;
            direction = 'N';
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // podeAndar = true;
            direction = 'S';
        }
        switch (direction)
        {
            case 'O':
                // if (podeAndar)
                //{
                transform.position += Vector3.left * playerSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 0);
                playerPosition = gameObject.transform.position;
                //}

                break;
            case 'E':
                //if (podeAndar)
                // {
                transform.position += Vector3.right * playerSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 180, 0);
                playerPosition = gameObject.transform.position;
                //}

                break;
            case 'N':
                //if (podeAndar)
                // {
                transform.position += Vector3.up * playerSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, -90);
                playerPosition = gameObject.transform.position;
                // }

                break;
            case 'S':
                //if (podeAndar)
                //{
                transform.position += Vector3.down * playerSpeed * Time.deltaTime;
                transform.rotation = Quaternion.Euler(0, 0, 90);
                playerPosition = gameObject.transform.position;
                //}

                break;
        }
        positionX = (int)transform.position.x;
        positionY = (int)transform.position.y;
        Debug.Log(playerPosition);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //comeu?
        if (collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            score += 100;
            //Debug.Log(score);
        }
        else if (collision.gameObject.tag == "PowerFood")
        {
            Destroy(collision.gameObject);
            score += 500;
        }

    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Obstacle")
    //    {
    //        podeAndar = false;
    //        Debug.Log("bateu");
    //    }
    //}
}
