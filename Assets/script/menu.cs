﻿using UnityEngine.SceneManagement;
using UnityEngine;

public class menu : MonoBehaviour {
    public void StartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
