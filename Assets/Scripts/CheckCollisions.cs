using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    public GameObject explosion;

    //On TriggerEnter se llamara automaticamente cuando un objeto fisico entre dentro del Trigger del Game Object
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Projectile"))
        {
            Instantiate(explosion, transform.position, transform.rotation);

            //Destruye el animal
            Destroy(this.gameObject);
            //Destruye lo otro
            Destroy(other.gameObject);
        }
        if (other.CompareTag("Enemy"))
        {
            Instantiate(explosion, transform.position, transform.rotation);

            //Destruye el animal
            Destroy(this.gameObject);
            //Destruye lo otro
            Destroy(other.gameObject);
        }
    }   
}