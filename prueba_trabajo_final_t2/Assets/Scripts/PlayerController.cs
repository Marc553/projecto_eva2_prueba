using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lives = 0;
    public float playerSpeed = 20f;
    public float bulletSpeed = 100f;
    
    public float verticalInput;
    public GameObject projectilPrefab;

    
    private Rigidbody playerRigidbody;
    [SerializeField] private float speed = 10f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

   
    void Update()
    { 
        //Movimiento
        
        verticalInput = Input.GetAxis("Vertical");

        playerRigidbody.AddForce(transform.forward * playerSpeed * verticalInput);

        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.rotation *= Quaternion.Euler(0, 90, 0);
        }

        //Disparo 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision otherCollider)
    {
        if(otherCollider.gameObject.CompareTag("enemigo"))
        {
            Destroy(gameObject);
        }

    }

}
