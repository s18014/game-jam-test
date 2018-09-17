using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zabuton : MonoBehaviour {
    public float power;
    public float angryPoint;
    Bullet bullet;
    bool isOnGround;
    Vector2 min;
    Vector2 size;


	// Use this for initialization
	void Start () {
        bullet = GetComponent<Bullet>();
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        size = GetComponent<SpriteRenderer>().bounds.size / 2f;
        isOnGround = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void FixedUpdate()
    {
        onGround();
        move();
    }

    void move () {
        Vector2 pos = transform.position;
        if (isOnGround)
        {
            pos.y = min.y + size.y;
            pos.x += bullet.speed * Time.deltaTime * 3f;
        }
        else
        {
            pos.x += Mathf.Cos(Mathf.Deg2Rad * bullet.angle) * Time.deltaTime * bullet.speed;
            pos.y += Mathf.Sin(Mathf.Deg2Rad * bullet.angle) * Time.deltaTime * bullet.speed;
        }
        transform.position = pos;
    }

    void onGround ()
    {
        if (min.y >= transform.position.y - size.y) isOnGround = true;
    }
}