using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletManager : MonoBehaviour {
    public DangoManager dango;
    public ZabutonManager zabuton;
    public FutonManager futon;

	// Use this for initialization
	void Start () {
        dango = GetComponent<DangoManager>();
        zabuton = GetComponent<ZabutonManager>();
        futon = GetComponent<FutonManager>();
	}
	
	// Update is called once per frame
	void Update () {
	}
}