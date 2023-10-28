using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDummyAttackWithSwords : MonoBehaviour
{
    public Stats stats;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Dummy 2"))
        {
            stats.dummyInAttackWithSwords = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Dummy 2"))
        {
            stats.dummyInAttackWithSwords = false;
        }
    }
}
