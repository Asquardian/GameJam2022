using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fixed : MonoBehaviour
{
    public Rigidbody2D rb; // вадрат
    public Rigidbody2D player; //»грок (кто бы мог подумать)
                           
    void Start()
    {
        rb.gameObject.AddComponent<FixedJoint2D>().connectedBody = player;
    }

    // Update is called once per frame
    void Update(){
        
    }
}
