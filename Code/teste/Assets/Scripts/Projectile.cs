using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{

    public LayerMask collisionMask;
    float speed = 10;
    float damage = 2;

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        float moveDistance = speed * Time.deltaTime;
        CheckCollisions(moveDistance);
        transform.Translate(Vector3.forward * moveDistance);
    }


    void CheckCollisions(float moveDistance)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, moveDistance, collisionMask, QueryTriggerInteraction.Collide))
        {
            OnHitObject(hit);
        }
    }

    void OnHitObject(RaycastHit hit)
    {
        IDamageable damageableObject = hit.collider.GetComponent<IDamageable>();
        if (damageableObject != null)
        {
            damageableObject.TakeHit(damage, hit);
        }
        GameObject.Destroy(gameObject);
    }

    
    

        public GameObject Gun;

        public GameObject bullet;

        public float bullet_forward_force;

        

        // Use this for initialization
        void Start()
        {

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

