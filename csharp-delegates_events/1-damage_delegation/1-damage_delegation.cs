﻿using System;


///<summary> Player's class</summary>
public class Player
{
    ///<summary> Player's poperties </summary>
    private string name;
    private float maxHp;
    private float hp;

    ///<summary> Player's Constructor </summary>
    public Player(string name="Player", float maxHp=100f)
    {
        this.name = name;
        if (maxHp <= 0f)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    ///<summary> Player's method for printing HP </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    ///<summary>TakeDamage delegate method</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
        }
        Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        hp -= damage;
    }

    ///<summary> TakeDamage delegate method </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
        }
        Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        hp += heal;
    }

    ///<summary> Calculate Health Delegate </summary>
    public delegate void CalculateHealth(float damage);
}