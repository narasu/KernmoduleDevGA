using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class EnemyManager
{
    public int enemyWaveAmount;
    public List<Enemy> enemyList = new List<Enemy>();
    public Vector3 playerPosition;

    private Enemy enemy;
    //DISCUSS: give health here or in the game manager
    private float health = 100;
    //placeholder values
    private float randomXValueMin = 1f;
    private float randomXValueMax = 10f;
    private float randomYValueMin = 1f;
    private float randomYValueMax = 10f;

    //DISCUSS: need the updated player position
    //SOLVED: GameManager Singleton
    public EnemyManager(/*vector3 _playerPosition?*/)
    {

        enemy = new Enemy(health);
        //start wave
        SpawnEnemies(10);
    }
    
    public void SpawnEnemies(/*float _health*/ int _enemyWaveAmount)
    {
        for(int i = 0; i < _enemyWaveAmount; i++)
        {
            //instantiate new enemy with _health + GiveRandomLocation()
            //
            //enemy add to enemylist
        }
        //spawn enemies
        //enemies in list?
    }

    public void OnDeath(Enemy _enemy)
    {
        enemyList.Remove(_enemy);
    }

    public void UpdateEnemies()
    {
        foreach(Enemy enemy in enemyList){
          enemy?.Update(playerPosition);
        }
    }

    private Vector3 GiveRandomLocation()
    {
        //give randomLocation for spawning
        Vector3 location = new Vector3(Random.Range(randomXValueMin, randomXValueMax), 0, Random.Range(randomYValueMin, randomYValueMax));
        return location;
    }

}
