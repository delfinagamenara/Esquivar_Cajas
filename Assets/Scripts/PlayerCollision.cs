using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
       CajaSpawner cajaSpawner;
   
    // Start is called before the first frame update
    void Start()
    {
    cajaSpawner = GetComponent<CajaSpawner>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.CompareTag ("Player"))
        {
         GetComponent<Rigidbody>().velocity = Vector3.zero;     
        GetComponent<CajaMovement>().enabled = false;            
        FindObjectOfType<TimeManager>().StopTimer();
            Destroy(col.gameObject);
        }
          else if (col.gameObject.CompareTag ("Plane"))
    {
        
    if (cajaSpawner != null)
    {
        cajaSpawner.LocateBoxAtRandomPosition();
    }
    }
    }
}
