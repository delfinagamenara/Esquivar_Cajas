using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaCollision : MonoBehaviour
{
    CajaSpawner cajaSpawner; 
    void Start()
{
    cajaSpawner = GetComponent<CajaSpawner>();
    Debug.Log("CajaSpawner en CajaCollision: " + cajaSpawner);
}
    void OnCollisionEnter (Collision col){
        if (col.gameObject.CompareTag ("Caja"))
        {
  if (cajaSpawner != null)
            {
                cajaSpawner.LocateBoxAtRandomPosition();
            }        }
    }
}
