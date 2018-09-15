using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZabutonManager : MonoBehaviour {
    public Zabuton zabuton;
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
        if (lapTime >= zabuton.coolTime)
        {
            isShotable = true;
        }
    }

    public void shot (GameObject origin)
    {
        if (isShotable)
        {
            Instantiate(zabuton, origin.transform.position, Quaternion.Euler(Vector2.right));
            isShotable = false;
            lapTime = 0f;
        }
    }

}