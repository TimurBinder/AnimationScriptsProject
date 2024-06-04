using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float offset = _speed * Time.deltaTime;
        transform.Translate(offset, 0, 0);
    }
}
