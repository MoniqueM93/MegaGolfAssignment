using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
