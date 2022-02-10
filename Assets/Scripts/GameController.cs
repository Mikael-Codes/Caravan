using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject[] statsValues;
    public GameObject refugeeValue;
    Stats stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = new Stats();
    }

    // Update is called once per frame
    void Update()
    {
        statsValues[0].GetComponent<TextMeshProUGUI>().text = stats.getWater().ToString() + '%';
        statsValues[1].GetComponent<TextMeshProUGUI>().text = stats.getShelter().ToString() + '%';
    }
}

public class Stats
{

    private int maxValue = 200;
    private int refugees;
    private int water;
    private int shelter;
    private int sustenance;
    private int resources;
    private int scouts;
    private int relics;

    private int hunting;
    private int protection;
    private int construction;

    private int scientific;
    private int cultural;
    private int archeological;

    public int getRefugees()
    {
        return this.refugees;
    }

    public void setRefugees(int refugees)
    {
        this.refugees = Mathf.Clamp(refugees, 0, 5000);
    }


    public int getWater()
    {
        return this.water;
    }

    public void setWater(int water)
    {
        this.water = Mathf.Clamp(water, 0, maxValue);
    }

    public int getShelter()
    {
        return this.shelter;
    }

    public void setShelter(int shelter)
    {
        this.shelter = Mathf.Clamp(shelter, 0, maxValue);
    }

    public int getSustenance()
    {
        return this.sustenance;
    }

    public void setSustenance(int sustenance)
    {
        this.sustenance = Mathf.Clamp(sustenance, 0, maxValue);
    }

    public int getResources()
    {
        return this.resources;
    }

    public void setResources(int resources)
    {
        this.resources = Mathf.Clamp(resources, 0, maxValue);
    }

    public int getScouts()
    {
        return this.scouts;
    }

    public void setScouts(int scouts)
    {
        this.scouts = Mathf.Clamp(scouts, 0, maxValue);
    }

    public int getRelics()
    {
        return this.relics;
    }

    public void setRelics(int relics)
    {
        this.relics = Mathf.Clamp(relics, 0, maxValue);
    }

    public int getHunting()
    {
        return this.hunting;
    }

    public void setHunting(int hunting)
    {
        this.hunting = Mathf.Clamp(hunting, 0, maxValue);
    }

    public int getProtection()
    {
        return this.protection;
    }

    public void setProtection(int protection)
    {
        this.protection = Mathf.Clamp(protection, 0, maxValue);
    }

    public int getConstruction()
    {
        return this.construction;
    }

    public void setConstruction(int construction)
    {
        this.construction = Mathf.Clamp(construction, 0, maxValue);
    }

    public int getScientific()
    {
        return this.scientific;
    }

    public void setScientific(int scientific)
    {
        this.scientific = Mathf.Clamp(scientific, 0, maxValue);
    }

    public int getCultural()
    {
        return this.cultural;
    }

    public void setCultural(int cultural)
    {
        this.cultural = Mathf.Clamp(cultural, 0, maxValue);
    }

    public int getArcheological()
    {
        return this.archeological;
    }

    public void setArcheological(int archeological)
    {
        this.archeological = Mathf.Clamp(archeological, 0, maxValue);
    }


    public Stats(){
        setRefugees(200);
        setWater(100);
        setShelter(100);
        setResources(100);
        setScouts(10);
        setRelics(0);

        setHunting(100);
        setProtection(100);
        setConstruction(100);

        setScientific(100);
        setCultural(100);
        setArcheological(100);
    }
}
