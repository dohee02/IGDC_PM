using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject ghost;

    public int score; //������� ���� ���� ����
    public int goal; //Ŭ��� �ʿ��� ���� ����

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

    void Place(GameObject obj) //obj�� �Լ� �ȿ����� ���̴� �Ű�����, place�� �༮���� ������ Gameobject�̹Ƿ� �̷��� ������ ������
    {
        obj.transform.position = new Vector3(Random.Range(minX, maxX), obj.transform.position.y, Random.Range(minZ, maxZ));
    }

    public void RaiseScore(int number)
    {
        score += number;
        Debug.Log("score : " +score);
    }
}
