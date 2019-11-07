using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainVariation : MonoBehaviour
{

    ParticleSystem Rain;
    // Start is called before the first frame update
    void Start()
    {
        Rain = gameObject.GetComponent<ParticleSystem>();
        Rain.enableEmission = true;
        Rain.emissionRate = 150;
    }

    // Update is called once per frame
    void Update()
    {
        float RainRate = 10f;
        float valToBeLerped = 150;
        valToBeLerped = Mathf.Lerp(150, 650, RainRate);
    }
}
