using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePlaySpeedControl : MonoBehaviour
{
    public ParticleSystem particleSystemToBeControlled;
    public float targetSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        var main = particleSystemToBeControlled.main;
        main.simulationSpeed = targetSpeed;
    }
}
