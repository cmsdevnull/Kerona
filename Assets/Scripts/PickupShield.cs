﻿using UnityEngine;

public class PickupShield : MonoBehaviour
{
    void OnTriggerEnter(Collider c){
        Destroy(transform.parent.gameObject);
    }
}
