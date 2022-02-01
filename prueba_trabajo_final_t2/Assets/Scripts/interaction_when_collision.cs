using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction_when_collision : MonoBehaviour
{
    public int counter = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("projectil"))
        { 
            
            Destroy(otherCollider.gameObject);
            //if(counter<= 0)
           


        }
    }
}
