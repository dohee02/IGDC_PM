using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject ghost;

    public int score;
    public int goal;

    public Transform posCube;
    public Transform negCube;

    private float minX, maxX, minZ, maxZ;

    // Start is called before the first frame update
    void Start()
    {
        minX = negCube.position.x;
        maxX = posCube.position.x;
        minZ = negCube.position.z;
        maxZ = posCube.position.z;

        Place(coin);
        Place(ghost);

        CheckClear();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckClear()
    {
        if (score >= goal)
            Debug.Log("Clear");
    }

    void Place(GameObject obj) //obj는 함수 안에서만 쓰이는 매개변수, place될 녀석들은 형식이 Gameobject이므로 이렇게 형식을 지정함
    {
        obj.transform.position = new Vector3(Random.Range(minX, maxX), obj.transform.position.y, Random.Range(minZ, maxZ));
    }
}
