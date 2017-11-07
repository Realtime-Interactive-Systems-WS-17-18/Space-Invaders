using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float _velocity;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + Vector3.down * _velocity * Time.deltaTime;
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ground")
        {
            Debug.Log("Lost 1 Health");
            GameManager.Instance.EnemyReachedGround();
        }
    }
}
