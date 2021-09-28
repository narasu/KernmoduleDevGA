using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//TODO: what's happening in this class?
//DISCUSS: EnemySpawner or EnemyManager
public class EnemySpawner
{
    private Enemy enemy;
    //DISCUSS: give health here or in the game manager
    private int health;

    //public List<Enemy> enemyList = new List<Enemy>();

    private float randomXValueMin = 1f;
    private float randomXValueMax = 10f;
    private float randomYValueMin = 1f;
    private float randomYValueMax = 10f;
    EnemySpawner()
    {
        enemy = new Enemy(health);
    }

    public void SpawnEnemies()
    {
        //spawn enemies
        //enemies in list?
    }

    public Vector3 GiveRandomLocation() 
    {
        //geef een random locatie, snelle placeholder
        Vector3 location = new Vector3(Random.Range(randomXValueMin,randomXValueMax),0, Random.Range(randomYValueMin, randomYValueMax));
        return location; 
    }
    
        
    
}
