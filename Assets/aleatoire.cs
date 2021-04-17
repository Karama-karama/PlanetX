using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aleatoire : MonoBehaviour
{
        public Rigidbody2D Comet;

    // Start is called before the first frame update
    void Start()
    {  
       Vector3 PositionComet = new Vector3 (Random.Range (-5,5), Random.Range(-5,5),2); 
      Comet = Instantiate (Comet, PositionComet, Quaternion.identity) as Rigidbody2D;
      print(PositionComet);  
    }

   
}
