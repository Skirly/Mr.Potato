using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject explosion;
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //Quaternion randomRotation = Quaternion.Euler(0f, 0f, Random.Range(0f, 360f));

		// Instantiate the explosion where the rocket is with the random rotation.
		//Instantiate(explosion, transform.position, randomRotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            float rotation = Random.Range(0, 360);
            Instantiate(explosion, transform.position,
                        Quaternion.Euler(0, 0, rotation));
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().Hurt();
        }
        if(collision.gameObject.tag == "BombPickup")
        {
			Destroy (gameObject);
        }
    }
}
