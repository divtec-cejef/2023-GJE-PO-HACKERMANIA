using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractObject : MonoBehaviour
{
    private bool triggerActive = false;

    void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Player")) {
                Debug.Log("dans le bt");
                triggerActive = true;
            }
        }

        void OnTriggerExit(Collider other) {
           if (other.CompareTag("Player")) {
               triggerActive = false;
           }
        }

        private void Update() {
             if (triggerActive && Input.GetKeyDown(KeyCode.JoystickButton0)) {
             Debug.Log("vous avez cliqué sur la touche");
        }
    }
}
 