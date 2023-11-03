using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform5 : MonoBehaviour
{
    public Stats stats;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stats.platform5active = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            stats.platform5active = false;
        }
    }
}
