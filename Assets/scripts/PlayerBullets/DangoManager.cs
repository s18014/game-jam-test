using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangoManager : MonoBehaviour {
    public Dango dango;
    float lapTime;
    bool isShotable;

	// Use this for initialization
	void Start () {
        isShotable = true;
        lapTime = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        lapTime += Time.deltaTime;
        if (lapTime >= dango.coolTime)
        {
            isShotable = true;
        }
    }

    public void shot (GameObject origin)
    {
        if (isShotable)
        {
            Instantiate(dango, origin.transform.position, Quaternion.Euler(Vector2.right));
            isShotable = false;
            lapTime = 0f;
        }
    }
}