using System;
using System.Collections.Generic;
using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class HomeScreen : MonoBehaviour
    {
        public AttractionEntryGraphics attractionEntryGraphics;
        public RectTransform attractionEntryRectTransform;
        public AttractionScript config;
        public List<AttractionScript> configFiles;
        public GameObject loginButton;
        public TMP_Text userName;
        private void Awake()
        {
            SetupUsername();    
            foreach (var config in configFiles)
            {
                var newAttraction = Instantiate(attractionEntryGraphics, attractionEntryRectTransform);
                newAttraction.Setup(config);
            }
        }

        private void SetupUsername()
        {
            if (PlayerPrefs.HasKey(PlayerData.playerDataKey))
            {
                loginButton.SetActive(false);
                userName.gameObject.SetActive(true);

                var playerData = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString(PlayerData.playerDataKey));
                userName.text = playerData.userName;
            }
            else
            {
                loginButton.SetActive(true);
                userName.gameObject.SetActive(false);
                userName.text = "";
            }
        }

        public void SignUp()
        {
            SceneManager.LoadScene("SignupPopup", LoadSceneMode.Additive);
        }
    }
}