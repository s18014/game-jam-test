using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dango : MonoBehaviour {
    public float power;
    public float angryPoint;
    Bullet bullet;


	// Use this for initialization
	void Start () {
        bullet = GetComponent<Bullet>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos.x += bullet.speed * Time.deltaTime;
        transform.position = pos;
    }


}