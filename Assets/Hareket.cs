using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Hareket : MonoBehaviour
{

    [SerializeField]
    int Hiz = 10;


    Rigidbody rb;
    // Use this for initializaation
    void Start()
    {
        rb = GetComponent<Rigidbody>(); ///fiziksel özellikleri alınmış

    }

    // Update is called once per frame
    void Update()
    {

        float yatay = Input.GetAxis("Horizontal");

        float dikey = Input.GetAxis("Vertical");
        Vector3 Hareket = new Vector3(yatay * Hiz, 0.0f, dikey * Hiz);
        rb.AddForce(Hareket);//force güç ekle demek
    }

    void FixedUpdate()
    {
        Rigidbody rb;
        rb = GetComponent<Rigidbody>(); ///fiziksel özellikleri alınmış


    }
}