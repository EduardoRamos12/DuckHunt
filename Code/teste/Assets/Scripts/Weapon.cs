using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {
    public GameObject bullet;
    public GameObject cam;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Shoot()
    {
        Destroy(Instantiate(bullet, cam.transform.position, cam.transform.rotation), 5f);
    }
}
