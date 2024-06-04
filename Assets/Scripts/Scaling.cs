using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        float offset = _speed * Time.deltaTime;
        float newScaleX = transform.localScale.x + offset;
        float newScaleY = transform.localScale.y + offset;
        float newScaleZ = transform.localScale.z + offset;
        transform.localScale = new Vector3(newScaleX, newScaleY, newScaleZ);
    }
}
