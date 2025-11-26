using UnityEngine;

public class Player_Core : MonoBehaviour
{
    /// <summary>
    /// Leveling System, Health and other stats and abilities are in this script. It should be the main script for holding both stats and buffs/debuffs
    /// </summary>

    #region Level Variables
    // level Variables
    [Header("Level Variables")]
    public int player_Level = 0;
    public int player_CurrentExp = 0;
    public int player_ExpCap = 50;
    public float levelExpLimitMultiplier = 1.5f;
    #endregion

    #region Base Stats
    // base stats variables
    [Header("Base Stats")]
    public float player_MaxHealth = 100;
    public float player_Damage = 10;
    public float player_AttackSpeed = 2;
    public float player_MoveSpeed = 3;

    // current values
    public float player_CurrentHealth;
    #endregion

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // ensure player starts with full health
        player_CurrentHealth = player_MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }

    #region Leveling System
    public void LevelUp()
    {
        Debug.Log("Current Experience = " +  player_CurrentExp);
        // check if the current experience is equal to the cap
        if (player_CurrentExp >= player_ExpCap)
        {
            // increase level
            player_Level++;
            Debug.Log("Current Level = " + player_Level);
            // increase experience cap for the next level
            player_ExpCap = (int)(player_ExpCap * levelExpLimitMultiplier);
            Debug.Log("New Exp Cap = " + player_ExpCap);
        }
    }

    public void GainExp (int gainedExp)
    {
        player_CurrentExp += gainedExp;
    }
    #endregion
}
