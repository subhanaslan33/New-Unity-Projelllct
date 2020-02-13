using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vedoo : MonoBehaviour
{

    [SerializeField]

    GameObject kure;
    Vector3 aradakifark;


    // Use this for initialization
    void Start()
    {
        aradakifark = transform.position - kure.transform.position;

        //aradaki farkı buluyoruz


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = kure.transform.position + aradakifark;



    }
}