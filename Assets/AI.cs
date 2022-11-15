using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public GameObject bullet;
    public Transform fp;
    private float fr = 1f, next = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        check();
    }

    void check()
    {
        if (Time.time > next)
        {
            Instantiate(bullet, fp.position, fp.rotation);
            next = Time.time + fr;
        }
    }
}
