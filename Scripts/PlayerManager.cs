﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    #region Singleton
    public static PlayerManager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion 

    public GameObject Player;
    public GameObject Hiding;
    public GameObject Objective;
    public GameObject Objective1;
    public GameObject Objective2;
    public GameObject Door;
}