using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float offset = _speed * Time.deltaTime;
        transform.localScale = new Vector3(transform.localScale.x + offset, transform.localScale.y + offset, transform.localScale.z + offset);
    }
}
