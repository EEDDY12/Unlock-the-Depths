using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ObjectiveUI : MonoBehaviour
{
    public TextMeshProUGUI objectiveText;   
    public int keysNeeded = 4;

    void Start()
    {
        objectiveText.text = "Objective: Collect 4 keys.";
    }

    void Update()
    {
        if (Inventory.keyCount >= keysNeeded)
        {
            objectiveText.text = "A door somewhere has opened... you should check it out.";
        }
        else
        {
            objectiveText.text = "Objective: Collect 4 keys.";
        }
    }
}
