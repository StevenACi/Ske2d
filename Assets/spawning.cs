using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject enemyOne;

    public GameObject enemyTwo;


    public GameObject enemyThree;

    public int counter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if (counter % 16 == 0){
            Instantiate(enemyOne, transform.position, Quaternion.identity);
        }
    }
}
