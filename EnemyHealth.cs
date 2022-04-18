using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int MaxHitPoint = 5;

    [Tooltip("Add amount to maxhit points when enemy die.")]
    [SerializeField] int difficultyRamp = 1;

    int currentHitPoint = 0;

    Enemy enemy;

    void Start() 
    {
        enemy = GetComponent<Enemy>();
    }

    void OnEnable()
    {
        currentHitPoint = MaxHitPoint;
    }

    void OnParticleCollision(GameObject other) 
    {
        ProcessHit();
    }
    void ProcessHit()
    {
        currentHitPoint--;
        if(currentHitPoint <= 0) 
        {  
            gameObject.SetActive(false);
            MaxHitPoint += difficultyRamp;
            enemy.RewardGold(); 
        }       
    }
}
