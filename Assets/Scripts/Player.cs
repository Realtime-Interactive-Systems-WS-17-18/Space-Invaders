using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float _velocity;

    public GameObject _bullet;

    public Transform _bulletTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("left"))
        {
            transform.position = transform.position + Vector3.left * Time.deltaTime * _velocity;
        }

        if (Input.GetKey("right"))
        {
            transform.position = transform.position + Vector3.right * Time.deltaTime * _velocity;
        }

        if (Input.GetKeyDown("space"))
        {
            Instantiate(_bullet, transform.position, Quaternion.identity, _bulletTransform);
        }
	}
}
