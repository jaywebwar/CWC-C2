using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTimePressed;
    [SerializeField] float dogSpawnInterval;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastTimePressed > dogSpawnInterval)
        {
            lastTimePressed = Time.time;

            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
