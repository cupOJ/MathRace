﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace KartGame.UI
{
    /// <summary>
    /// A MonoBehaviour for controlling the different panels of the main menu.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        [Tooltip("A collection of UI panels, one of which will be active at a time.")]
        public GameObject[] panels;

        /// <summary>
        /// Turns off all the panels except the one at the given index which is turned on.
        /// </summary>
        public void SetActivePanel(int index)
        {
            for (var i = 0; i < panels.Length; i++)
            {
                bool active = i == index;
                GameObject panel = panels[i];
                if (panel.activeSelf != active)
                    panel.SetActive(active);
            }
        }

        public void resumeBtn()
        {
            MetaGameController ii = GameObject.Find("MetaGameController").GetComponent<MetaGameController>();
            ii.HandleMenuButton();
        }
        public void mainMenuBtn()
        {
            SceneManager.LoadScene("Main menu");
        }

        public void quitGameBtn()
        {
            Application.Quit();
        }

        void OnEnable()
        {
            SetActivePanel(0);
        }
    }
}