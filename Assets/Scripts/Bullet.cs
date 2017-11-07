using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

    public float _velocity;
    public Vector3 _moveDirection;
    public float _lifeTime;
	
	// Update is called once per frame
	void Update () {

        transform.position = transform.position + _moveDirection * _velocity * Time.deltaTime;

        _lifeTime += Time.deltaTime;
        if (_lifeTime > 1f)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Debug.Log("Destroy Enemy");
            GameManager.Instance.NewEnemyDestroyed();
        }
    }
}
