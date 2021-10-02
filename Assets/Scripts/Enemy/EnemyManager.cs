using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//TODO: figure out what's happening in this class?
public class EnemyManager
{
    private Enemy enemy;
    //DISCUSS: give health here or in the game manager
    private float health = 100;
    public int enemyWaveAmount;
    public List<Enemy> enemyList = new List<Enemy>();

    private float randomXValueMin = 1f;
    private float randomXValueMax = 10f;
    private float randomYValueMin = 1f;
    private float randomYValueMax = 10f;

    //DISCUSS: need the updated player position
    //SOLVED: GameManager Singleton
    EnemyManager(/*playerposition?*/ int enemyWaveAmount)
    {
        enemy = new Enemy(health);
    }

    //DISCUSS: can spawn enemies with other healths from here, but would this be a good idea?
    public void SpawnEnemies(/*float _health*/)
    {
        for(int i = 0; i < enemyWaveAmount; i++)
        {
            //instantiate new enemy with _health + GiveRandomLocation()
            //
            //enemy add to enemylist
        }
        //spawn enemies
        //enemies in list?

    }

    //reference to the player instance?
    public void UpdateEnemies()
    {
        foreach(Enemy enemy in enemyList){
          enemy?.Update(/*playerposition?*/);
        }
    }

    private Vector3 GiveRandomLocation() 
    {
        //geef een random locatie, placeholder
        Vector3 location = new Vector3(Random.Range(randomXValueMin,randomXValueMax),0, Random.Range(randomYValueMin, randomYValueMax));
        return location; 
    }    
    
}
