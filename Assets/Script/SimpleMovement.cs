using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SimpleMovement : MonoBehaviour
{
    public float speed = 5f;
    public Buttons[] input;

    public Rigidbody2D body2d;
    private InputState inputState;

    // Start is called before the first frame update
    void Start()
    {
        body2d=GetComponent<Rigidbody2D>();
        inputState=GetComponent<InputState>();
    }

    // Update is called once per frame
    void Update()
    {
        //var val = Input.GetAxis("Horizontal");
        //body2d.velocity = new Vector2(speed * val,body2d.velocity.y);
        //var val2 = Input.GetAxis("Vertical");
        //body2d.velocity = new Vector2(body2d.velocity.x, speed * val2);
        var right = inputState.GetButtonValue(input[0]);
        var left = inputState.GetButtonValue(input[1]);
        var top = inputState.GetButtonValue(input[2]);
        var buttom = inputState.GetButtonValue(input[3]);
        var velx = speed;
        if(right || left)
        {
            if (left)
            {
                velx = velx * -1;
            }
        }
        else if(top || buttom)
        {
            if (buttom)
            {
                velx = velx * -1;
            }
        }
        else
        {
            velx = 0;
        }
       
           body2d.velocity = new Vector2(velx, body2d.velocity.y);
          
          //  body2d.velocity = new Vector2(body2d.velocity.x, velx);
     

    }
}
