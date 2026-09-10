using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Bar[] _bars;

    private void Start()
    {
        foreach (var bar in _bars)
            bar.Initialize(_health.CurrentValue, _health.MaxValue);
    }

    private void OnEnable()
    {
        foreach (var bar in _bars)
            _health.ValueChanged += bar.OnHealthValueChanged;
    }

    private void OnDisable()
    {
        foreach (var bar in _bars)
            _health.ValueChanged -= bar.OnHealthValueChanged;
    }
}
