using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayHealth : MonoBehaviour
{
    private Health _health;
    [SerializeField] private TextMeshProUGUI _text;

    public void Initialize(Health health)
    {
        _health = health;
    }

    private void Update()
    {
        DisplayText();
    }

    private void DisplayText()
    {
        _text.text = "Health:" + _health.HealthPoints;
    }
}
