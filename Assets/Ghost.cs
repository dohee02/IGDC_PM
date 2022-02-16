using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public Transform player;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        ChaseTarget(player);
    }

    public void ChaseTarget(Transform trans)
    {
        transform.Translate(new Vector3(
              trans.position.x - transform.position.x
            , trans.position.y - transform.position.y
            , trans.position.z - transform.position.z).normalized*Time.deltaTime * speed);
    }
}
