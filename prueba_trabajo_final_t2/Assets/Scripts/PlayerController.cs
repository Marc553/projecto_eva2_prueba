using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lives = 0;
    public float playerSpeed = 20f;
    public float bulletSpeed = 100f;
    public float horizontalInput;
    public float verticalInput;
    public GameObject projectilPrefab;

    void Start()
    {
       
    }

   
    void Update()
    { 
        //Movimiento
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * playerSpeed * Time.deltaTime * verticalInput);
        transform.Translate(Vector3.back * playerSpeed * Time.deltaTime * horizontalInput);

        //Disparo 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }
    }
}
