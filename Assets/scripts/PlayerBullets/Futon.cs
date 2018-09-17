using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Futon : MonoBehaviour {
    public float power;
    public float angryPoint;
    public float gravity;
    Bullet bullet;
    float vx = 0f;
    float vy = 0f;


	// Use this for initialization
	void Start () {
        bullet = GetComponent<Bullet>();
        vx = Mathf.Cos(Mathf.Deg2Rad * bullet.angle) * bullet.speed;
        vy = Mathf.Sin(Mathf.Deg2Rad * bullet.angle) * bullet.speed;
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void FixedUpdate()
    {
        vy -= gravity * 9.81f * Time.deltaTime;
        Vector2 pos = transform.position;
        pos.x += vx * Time.deltaTime;
        pos.y += vy * Time.deltaTime;
        transform.position = pos;
        
    }
}
