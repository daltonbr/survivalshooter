using UnityEngine;
using System.Collections;

public class IntroManager : MonoBehaviour {

    // Update is called once per frame
    void Update() {
        if ((Input.GetButtonDown("Cancel")) || (Input.GetButton("Fire1")) )
        {
            Application.LoadLevel(1); // carrega fase 1 (unica)
        }
    }
}
