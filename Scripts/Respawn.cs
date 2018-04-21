using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

public float ZRespawnFloat;
   void OnTriggerEnter(Collider Col)
     {
       if (Col.gameObject.CompareTag("Cars")){
          // Destroy (Col.gameObject, 0);
       
       //	  Col.transform.position = new Vector3(30.60f, -8.14f, -6635.2f);
       	  Col.transform.Translate(0.0f, 0.0f, ZRespawnFloat);

       }
        
     }
}