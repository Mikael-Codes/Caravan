using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject[] statsValues;
    Stats stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats();
    }

    // Update is called once per frame
    void Update()
    {
        statsValues[0].GetComponent<TextMeshProUGUI>().text = stats.atmosphere.ToString() + '%';
        statsValues[1].GetComponent<TextMeshProUGUI>().text = stats.gravity.ToString() + '%';
    }
}

public class Stats
{
    public int atmosphere, gravity, temperature, water, resources; 
    public Stats(){
        atmosphere = 100;
        gravity = 100;
        temperature = 100;
        water = 100;
        resources = 100;
    }
}
