using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;

    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        float moveZ = 0f;
        float moveX = 0f;


        if (Input.GetKey(KeyCode.W))
        {
            moveZ += 1f;
        }

        if(Input.GetKey(KeyCode.S))
        {
            moveZ -= 1f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX -= 1f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveX += 1f;
        }

        transform.Translate(new Vector3(moveX, 0f, moveZ).normalized *Time.deltaTime* speed);

   
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Coin")
        {
            gameManager.GetComponent<GameManager>().RaiseScore(1);
        }
        else if (collision.gameObject.name == "Ghost")
        {
            Debug.Log("Over");
            speed = 0;
            Destroy(collision.gameObject);
        }


    }

    
}
