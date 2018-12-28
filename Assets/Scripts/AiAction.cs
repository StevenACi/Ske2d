using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiAction : MonoBehaviour
{

    //speed at which it takes actions
    public float speed = 0.00f;

    //general damage attribute//
    public float power = 0.00f;

    /************************/
    //physical related params
    /************************/

    //to determine accuracy
    public float accuracy = 0.00f;
    //to determine armour pen
    public float alacrity = 0.00f;

    //propentency to use magic or physical attacks
    public float magicMod = 0.00f;
    public float physicalMod = 0.00f;

    /************************/
    //magic related params  //
    /************************/

    /*damage and special effect modifier*/
    public float devotion = 0.00f;
    /*damage and cast-point speed*/
    public float concentration = 0.00f;

    /************************/
    /*UN-USED*/
    /************************/

    public float left = 0.00f;
    public float right = 0.00f;
    public float front = 0.00f;
    public float back = 0.00f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }
}
