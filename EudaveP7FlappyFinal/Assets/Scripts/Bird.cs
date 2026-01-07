using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    public float upForce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< HEAD
        rb2d = GetComponent<Rigidbody2D>();
=======
         rb2d = GetComponent<Rigidbody2D> ();
>>>>>>> 3d228d6318f9d9d1cd978842fe6d6c1c6118c816
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if (isDead == false)
        {
            if (Input.GetMouseButtonDown (0))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upForce));
                anim.SetTrigger ("Flap");
            }
        }
    }
    void OnCollisionEnter2D ()
    {
        isDead = true;
        anim.SetTrigger ("Die");
=======
         if (isDead == false)
         {
             if (Input.GetMouseButtonDown(0))
             {
                 rb2d.velocity = Vector2.zero;
                 rb2d.AddForce(new Vector2 (0, upForce));
                anim.SetTrigger("Flap");
             }
         }
>>>>>>> 3d228d6318f9d9d1cd978842fe6d6c1c6118c816
    }

    void OnCollisionEnter2D()
    {
        rb2d.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied ();
    }
 }        
