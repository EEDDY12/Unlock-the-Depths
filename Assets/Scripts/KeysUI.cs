using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeysUI : MonoBehaviour
{
    public TextMeshProUGUI keyText;

    void Update()
    {
        keyText.text = "Keys: " + Inventory.keyCount;
    }
}
