using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaMovement : MonoBehaviour
{
    public float speed;
     public float speedIncrement;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
 rb.velocity = new Vector3(0, -speed, 0);    }
     public void IncreaseSpeed()
    {
        speed += speedIncrement;
    }
}
