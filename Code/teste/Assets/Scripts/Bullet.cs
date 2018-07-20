using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

    public GameObject Gun;

    public GameObject bullet;

    public float bullet_forward_force;

    private float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown("space")) {

            GameObject Temporary_Bullet_Handler;
            Temporary_Bullet_Handler = Instantiate(bullet, Gun.transform.position, Gun.transform.rotation) as GameObject;

            //Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

            Rigidbody Temporary_Rigidbody;
            Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

            Temporary_Rigidbody.AddForce(transform.forward * bullet_forward_force);

            Destroy(Temporary_Bullet_Handler, 5.0f);

        }
    }

    public void Shoot()
    {
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(bullet, Gun.transform.position, Gun.transform.rotation) as GameObject;

        //Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

        Rigidbody Temporary_Rigidbody;
        Temporary_Rigidbody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        Temporary_Rigidbody.AddForce(transform.forward * bullet_forward_force);

        Destroy(Temporary_Bullet_Handler, 5.0f);
    }
}
