using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heigthRange = .45f;
    [SerializeField] private GameObject _pipe;
    private float _timer;

    void Start() => Spawn();


    void Update()
    {
        if (_timer > _maxTime)
        {
            Spawn();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void Spawn()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heigthRange, +_heigthRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

        Destroy(pipe, 10f);
    }
}
