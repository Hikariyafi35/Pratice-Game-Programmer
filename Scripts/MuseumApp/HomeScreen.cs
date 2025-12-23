using System.Collections.Generic;
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
        private void Awake() {
            foreach (var config in configFiles)
            {
                var newAttraction = Instantiate(attractionEntryGraphics, attractionEntryRectTransform);
                newAttraction.Setup(config);
            }
        }
        public void SignUp()
        {
            SceneManager.LoadScene("SignupPopup", LoadSceneMode.Additive);
        }
    }
}