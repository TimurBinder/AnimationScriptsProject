using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float offset = _speed * Time.deltaTime;
        transform.Rotate(0, offset, 0);
    }
}
