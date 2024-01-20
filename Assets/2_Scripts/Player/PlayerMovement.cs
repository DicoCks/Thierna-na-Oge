using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Vector2 dir = Vector2.zero;
    
    protected virtual void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        dir.x = Input.GetAxis("Horizontal");
        dir.y = Input.GetAxis("Vertical");
    
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
