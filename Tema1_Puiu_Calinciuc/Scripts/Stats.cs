using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public bool enteredInAttackRange;
    public bool enteredInDefenceRange;

    public bool dummyInAttack;
    public bool dummyInAttackWithSwords;

    public long timeInTotal;
    public long timeInGame;
    public long timeInMainMenu;

    private float timer = 0f;
    private float interval = 1f;

    public GameObject piticiForDummy1;
    public GameObject piticiForDummy2;
    void Start()
    {
        enteredInAttackRange = false;
        enteredInDefenceRange = false;
        dummyInAttack = false;
        dummyInAttackWithSwords = false;

        piticiForDummy1.SetActive(false);
        piticiForDummy2.SetActive(false);
    }

    void Update()
    {
        timer += Time.deltaTime;
        // Check if the interval has passed
        if (timer >= interval)
        {
            timer = 0f;
            dummyInAttack = false;
        }

        timeInTotal = timeInGame + timeInMainMenu;

        if (dummyInAttackWithSwords == true)
        {
            piticiForDummy1.SetActive(true);
            piticiForDummy2.SetActive(true);
        }
        else
        {
            piticiForDummy1.SetActive(false);
            piticiForDummy2.SetActive(false);
        }
    }
}
