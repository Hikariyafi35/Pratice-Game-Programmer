using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using System.Collections.Generic;
namespace MuseumApp
{
    public class AttractionEntryGraphics : MonoBehaviour
    {
        public string ID;
        public TMP_Text Tittle;
        public TMP_Text Author;
        public TMP_Text Description;
        public TMP_Text Location;
        public Image Image;
        public AttractionScript attractionConfig;
        public AttractionScreenParameters parametersPrefabs;

        public List<Image> starsImages;
        public Color activeColor;
        public Color inactiveColor;
        public int activeStars = 2;
        public void AttractionEntryOnClick()
        {
            SceneManager.LoadScene("AttractionScreen", LoadSceneMode.Single);
            var parameters = Instantiate(parametersPrefabs);
            parameters.config = attractionConfig;
        }
        public void Setup(AttractionScript _config)
        {
            attractionConfig = _config;
            Tittle.text = _config.Tittle;
            Location.text = _config.Location;
            Image.sprite = _config.Image;
            var rectTransform = Image.rectTransform;
            rectTransform.anchoredPosition3D = _config.thumbnailPosition;
            rectTransform.sizeDelta = _config.thumbnailSize;
        }
    }
}