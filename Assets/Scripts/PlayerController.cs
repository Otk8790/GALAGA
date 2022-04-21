using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float tilt;
    
    public float xRange = 15.0f;
    public float zRange = 0f;

    public GameObject[] projectilePrefab;
    public GameObject[] projectilePrefab2;
    private int projectileIndex;
    private int projectileIndex2;
    public Vector3 firingPointOffset = new Vector3(0f, 0f, 0f);
    public Vector3 firingPointOffset2 = new Vector3(0f, 0f, 0f);

    private Rigidbody rig;

    public GameController other;


    private void Awake()
    {
        rig = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);
        rig.velocity = movement * speed;
        rig.rotation = Quaternion.Euler(0f, 0f, rig.velocity.x * - tilt);

        //Derecha e izquierda
        if (transform.position.x < -xRange)
        //Se sale a la izquierda de la pantalla
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > xRange)
        //Se sale a la derecha de la pantalla
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Frente y atras
        if (transform.position.z < -zRange)
        //Se sale a la izquierda de la pantalla
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        
        if (transform.position.z > zRange)
        //Se sale a la derecha de la pantalla
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
        
        //Acciones del personaje
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (other.gameOver == true)
            {
                Destroy(this.gameObject);
            }
            else
            {

                Instantiate(projectilePrefab[projectileIndex], transform.position + firingPointOffset, projectilePrefab[projectileIndex].transform.rotation);
                Instantiate(projectilePrefab2[projectileIndex2], transform.position + firingPointOffset2, projectilePrefab2[projectileIndex2].transform.rotation);
            }

        }
        
        projectileIndex = Random.Range(0, projectilePrefab.Length);
        projectileIndex2 = Random.Range(0, projectilePrefab2.Length);
    }

}
