using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Hareket : MonoBehaviour
{
    public float donushizi = -90;
    public float hiz = 3;


    private Rigidbody2D rigid;
    void Start()
    {

        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.angularVelocity = Input.GetAxis("Horizontal") * donushizi;

        rigid.velocity = transform.up * Input.GetAxis("Vertical") * hiz;



    }
}
