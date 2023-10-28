using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderDummy : MonoBehaviour
{
    public Stats stats;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Dummy 2"))
        {
            stats.dummyInAttack = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Dummy 2"))
        {
            stats.dummyInAttack = false;
        }
    }
}
