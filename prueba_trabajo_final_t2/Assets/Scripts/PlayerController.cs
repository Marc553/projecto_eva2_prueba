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

    public GameObject focalPoint;
    private Rigidbody playerRigidbody;
    [SerializeField] private float speed = 10f;
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Pelota");
    }

   
    void Update()
    { 
        //Movimiento
        horizontalInput = Input.GetAxis("Horizontal");  
        verticalInput = Input.GetAxis("Vertical");

        playerRigidbody.AddForce(focalPoint.transform.forward * playerSpeed * verticalInput);
        playerRigidbody.AddForce(focalPoint.transform.right * playerSpeed * horizontalInput);
       
       // float verticalInput = Input.GetAxis("Vertical");
        //playerRigidbody.AddForce(Vector3.left * speed * horizontalInput);


        //Disparo 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilPrefab, transform.position, projectilPrefab.transform.rotation);
        }
    }
}
