using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mm1 : MonoBehaviour {

    private float damage;
    private float speed = 10f;
    private float lifespan = 100f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        lifespan -= 0.01f;
        if (lifespan <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position += (transform.right * speed * Time.deltaTime);
        }
        Debug.Log(transform.position);


	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("enemyhit");
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
