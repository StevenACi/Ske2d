using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {


    public GameObject primaryAtk;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.J))
        {
            Instantiate(primaryAtk, transform.position, Quaternion.identity);
        }
    }
}
