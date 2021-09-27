using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] float movespeed = 1f;
    Rigidbody2D myRigidbody;
   
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    { if (isfacingRight())
            myRigidbody.velocity = new Vector2(movespeed,0f);
        else
            myRigidbody.velocity = new Vector2(-movespeed,0f);   
    }
    private bool isfacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), transform.localScale.y);
    }
}
