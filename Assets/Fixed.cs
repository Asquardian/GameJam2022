using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    public Rigidbody2D rb; //�������
    public Rigidbody2D player; //����� (��� �� ��� ��������)
                           
    void Start()
    {
        rb.gameObject.AddComponent<FixedJoint2D>().connectedBody = player;
    }

    // Update is called once per frame
    void Update(){
        
    }
}
