using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Futon : MonoBehaviour {
    public float power;
    public float angryPoint;
    public float speed;
    public float angle;
    public float coolTime;
    public float gravity;
    float vx = 0f;
    float vy = 0f;


	// Use this for initialization
	void Start () {
        vx = Mathf.Cos(Mathf.Deg2Rad * angle) * speed;
        vy = Mathf.Sin(Mathf.Deg2Rad * angle) * speed;
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

    private void OnTriggerExit2D(Collider2D c)
    {
        string layerName = LayerMask.LayerToName(c.gameObject.layer);
        if (layerName == "DestroyArea")
        {
            Destroy(gameObject);
        }
    }
}
