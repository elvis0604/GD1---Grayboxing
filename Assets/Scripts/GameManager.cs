﻿using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static Player player;
    static Dictionary<string, Enemy> enemies = new Dictionary<string, Enemy>();

    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }

    public static void RegisterPlayer(Player p)
    {
        player = p;
        player.transform.name = p.player_name;
    }

    public static void RegisterEnemy(string enemy_id, Enemy enemy)
    {
        enemies.Add(enemy_id, enemy);
        enemy.transform.name = enemy_id;
    }

    public static Enemy GetEnemy(string enemy_id)
    { 
        return enemies[enemy_id];
    }

    public static Player GetPlayer()
    {
        return player;
    }

    public static void UnregisterEnemy(string enemy_id)
    {
        Debug.Log("Unregistering: " + enemy_id);
        enemies.Remove(enemy_id);
    }

    public GameObject player_object;
}
