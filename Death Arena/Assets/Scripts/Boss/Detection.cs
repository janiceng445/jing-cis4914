﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) {
        if (collider.tag == "Player") {
            this.transform.parent.GetComponent<Boss>().inRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        if (collider.tag == "Player") {
            this.transform.parent.GetComponent<Boss>().inRange = false;
        }
    }
}
