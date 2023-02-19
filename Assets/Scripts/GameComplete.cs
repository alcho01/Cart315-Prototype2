using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour
{

    [SerializeField] Text LevelCompleteText;

    void Start()
    {
        LevelCompleteText.gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerController component = other.gameObject.GetComponent<PlayerController>();
        if (component != null)
        {
            LevelComplete();
            Time.timeScale = 0f;
        }
    }

    public void LevelComplete()
    {
        LevelCompleteText.gameObject.SetActive(true);
    }
}
