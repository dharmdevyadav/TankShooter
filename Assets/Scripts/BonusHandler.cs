using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BonusHandler : MonoBehaviour
{
    public TextMeshProUGUI BonusPointText;

    private void Start()
    {
        BonusPointText = FindObjectOfType<TextMeshProUGUI>();
    }
}
