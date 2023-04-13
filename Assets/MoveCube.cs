using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Rigidbody2D rigidbody2D;
    public Color playercolor;
    public float speed;
    public KeyCode upkey;
    public KeyCode downkey;
    public KeyCode leftkey;
    public KeyCode rightkey;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = playercolor;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");

        if(Input.GetKey(upkey) && transform.position.y < 5)
        {
            rigidbody2D.velocity = Vector2.up * speed;
        }
        else if(Input.GetKey(downkey) && transform.position.y > -5)
        {
            rigidbody2D.velocity = Vector2.down * speed;
        }
        else if (Input.GetKey(rightkey))
        {
            rigidbody2D.velocity = Vector2.right * speed;
        }
        else if (Input.GetKey(leftkey))
        {
            rigidbody2D.velocity = Vector2.left * speed;
        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }




        
    }
}
