using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    public GameObject enemyOne;

    public GameObject enemyTwo;


    public GameObject enemyThree;

    public int counter;

    public bool isActive = false;
    public bool vectUp = false;
    private Vector3 change;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive)
        {
            counter++;
            if (counter % 8 == 0)
            {
                Instantiate(enemyOne, transform.position, Quaternion.identity);
            }
            if (counter >= 160)
            {
                counter = 0;
            }
        }
        if (vectUp){
            change.y -= 0.01f;
        }
        else
        {
            change.y += 0.01f;
        }
       transform.position += change * Time.deltaTime;
  
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Wall")
        {
            Debug.Log("WALL HIT");
            if (vectUp == false)
            {
                vectUp = true;
            }
            if (vectUp == true)
            {
                vectUp = false;
            }
        }
    }


}
