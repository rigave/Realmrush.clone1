using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int gold = 25;

    Bank bank;

    void Start()
    {
        bank = FindObjectOfType<Bank>();
    }

    public void RewardGold()
    {
        if(bank == null) { return; }
        bank.Deposit(gold);
    }

    public void StealdGold()
    {
        if(bank == null) { return; }
        bank.Withdraw(gold);
    }
}
