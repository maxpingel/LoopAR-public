﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataTrigger : MonoBehaviour
{
    [SerializeField] private TestEventManager testEventManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<ManualController>())
        {
            testEventManager.SaveDataTrigger();
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
