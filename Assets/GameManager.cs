using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {

    public int enemiesDestroyed;

    public Text enemyCountText;

    public int maxHealth;
    private int health;

    public Image healthBar;
    public Text healthText;

    public GameObject lostScreen;

    public EnemyController enemyController;

	// Use this for initialization
	void Start () {
        Init();
    }

    private void Init()
    {
        enemiesDestroyed = 0;
        health = maxHealth;
        healthText.text = "Health: " + health;
    }
	
    public void NewEnemyDestroyed()
    {
        enemiesDestroyed++;
        enemyCountText.text = "Enemies: " + enemiesDestroyed;
    }

    public void EnemyReachedGround()
    {
        health--;
        healthBar.fillAmount = (float)health / (float)maxHealth;
        healthText.text = "Health: " + health;

        if(health <= 0)
        {
            LostScreen();
        }
    }

    private void LostScreen()
    {
        StartCoroutine(ShowLostScreen());
    }

    IEnumerator ShowLostScreen()
    {
        lostScreen.SetActive(true);
        enemyController.DestroyAllEnemies();
        enemyController.spawn = false;
        yield return new WaitForSeconds(5f);
        lostScreen.SetActive(false);
        Init();
        enemyController.spawn = true;
    }



	// Update is called once per frame
	void Update () {
		
	}
}
