using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zabuton : MonoBehaviour {
    public float power;
    public float angryPoint;
    public float speed;
    public float coolTime;
    public float angle;
    bool isOnGround;
    Vector2 min;
    Vector2 size;


	// Use this for initialization
	void Start () {
        min = Camera.main.ViewportToWorldPoint(Vector2.zero);
        size = GetComponent<SpriteRenderer>().bounds.size / 2f;
        isOnGround = false;
	}
	
	// Update is called once per frame
	void Update () {
        onGround();
        Vector2 pos = transform.position;
        if (isOnGround)
        {
            pos.y = min.y + size.y;
            pos.x += speed * Time.deltaTime * 3f;
        } else
        {
            pos.x += Mathf.Cos(Mathf.Deg2Rad * angle) * Time.deltaTime * speed;
            pos.y += Mathf.Sin(Mathf.Deg2Rad * angle) * Time.deltaTime * speed;
        }
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

    void onGround ()
    {
        if (min.y >= transform.position.y - size.y) isOnGround = true;
    }
}