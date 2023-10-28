using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorDummy : MonoBehaviour
{
    public Stats stats;
    public Animator ANI;

    public GameObject sword;
    public GameObject shield;

    void Start()
    {
        sword.SetActive(false);
        shield.SetActive(false);
    }

    void Update()
    {
        if (stats.dummyInAttack == true)
        {
            ANI.SetTrigger("Attack");
        }
        else
        {
            ANI.SetTrigger("Idle");
        }

        if (stats.dummyInAttackWithSwords == true)
        {
            sword.SetActive(true);
            shield.SetActive(true);
        }
        else
        {
            sword.SetActive(false);
            shield.SetActive(false);
        }

    }
}
