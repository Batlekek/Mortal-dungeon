using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour { 
    [SerializeField]
    public float speed;

    private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        input();
        OnAnimatorMove();
    }
    public void OnAnimatorMove()
    {
        transform.Translate(Vector2.right*speed*Time.deltaTime); 
    }
    private void input()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction = Vector2.left;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction = Vector2.down;
        }
    }
}
