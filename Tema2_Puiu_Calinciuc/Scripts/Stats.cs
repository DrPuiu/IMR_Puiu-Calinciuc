using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int points;

    public bool platform1active;
    public bool platform2active;
    public bool platform3active;
    public bool platform4active;
    public bool platform5active;
    public bool platform6active;

    public long timeInTotal;
    public long timeInGame;
    public long timeInMainMenu;

    private float timer = 0f;
    private float interval = 1f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        points = 0;

        platform1active = false;
        platform2active = false;
        platform3active = false;
        platform4active = false;
        platform5active = false;
        platform6active = false;
    }

    void Update()
    {
       
    }
}
