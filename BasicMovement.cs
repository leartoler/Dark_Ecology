using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    public float speed;
    float someScale; //Para que señale la cara. 
    //public string idleAnimation = "Idle";
    public string walkAnimation = "Walk";
    
    enum State {IDLE, WALKING};
    private State state = State.IDLE;

    void Start()
    {
        someScale = transform.localScale.x;
        state = State.IDLE;
    }

  
    void Update()
    {
       
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector2(-someScale, transform.localScale.y);// permite que la cara señale a donde se mueve
            transform.Translate(new Vector2(speed * Time.deltaTime, 0));           //Movimiento   
            state = State.WALKING;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector2(someScale, transform.localScale.y);// permite que la cara señale a donde se mueve 
            transform.Translate(new Vector2(-speed * Time.deltaTime, 0));        //Movimiento
            state = State.WALKING;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector2(0, 1) * speed * Time.deltaTime);
            state = State.WALKING;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector2(0, -1) * speed * Time.deltaTime);
            state = State.WALKING;
        }      

    }
}
