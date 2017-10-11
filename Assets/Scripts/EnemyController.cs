using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject _enemy;

    public int _enemiesPerRow;

    public float _enemySpawnTime;

    public float _currentTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _currentTime += Time.deltaTime;

        if(_currentTime > _enemySpawnTime)
        {
            _currentTime = 0f;
            SpawnNewEnemyLine();
        }

    }

    void SpawnNewEnemyLine()
    {
        for(int i = 0; i < _enemiesPerRow; i++)
        {
            Instantiate(_enemy, transform.position + Vector3.right * i *3 - (Vector3.right * _enemiesPerRow * 3)/2, Quaternion.identity, transform);
        }
    }
}
