using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class status : MonoBehaviour
{
    private Animator animator;
    public float hp;
    private bool killed = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!killed)
        {
            if (hp <= 0)
            {
                animator.SetTrigger("Dead");
                Destroy(GetComponent<Movement>());
                Destroy(GetComponent<Attack>());

                killed = true;
            }
        }
    }
}
