using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour
{
    public static PlayerInformation PI;
    public string playerName = "Artemis";
    public int playerLevel = 1;
    public float expRequired = 100;
    public float currentExperience = 0;
    public float levelMultiplier = 1.05f;
    public int maxHealth = 20;
    public int currentHealth = 20;
    public int baseAttack = 5;
    public int baseDefense = 2;

    public int currency = 0;

    public Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    void Update()
    {
        if(currentExperience >= expRequired)
        {
            LevelUp();        
        }

        if(currentHealth <= 0)
        {
            Death();
        }
    }

    void LevelUp()
    {
        playerLevel++;
        expRequired = expRequired * levelMultiplier;
        levelMultiplier = levelMultiplier * 1.05f;

    }

    void Death()
    {

    }
}
