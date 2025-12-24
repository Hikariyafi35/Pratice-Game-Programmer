using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour
    {
        public Image attractionImageCover;
        public TMP_Text attractionTitle;
        public TMP_Text attractionAuthor;
        public TMP_Text attractionDescription;
        public TMP_Text attractionLocation;

        public List<Image> stars;
        public Color activeColor;
        public Color inactiveColor;

        private AttractionScreenParameters parameters;
        private AttractionScript attractionConfig;
        private void Start() {
            parameters = GameObject.FindObjectOfType<AttractionScreenParameters>();
            attractionConfig = parameters.config;

            attractionTitle.text = attractionConfig.Tittle;
            attractionAuthor.text = attractionConfig.Author;
            attractionDescription.text = attractionConfig.Description;
            attractionLocation.text = attractionConfig.Location;
            //handle header and star rating
            attractionImageCover.sprite = attractionConfig.Image;
            var rectTransform = attractionImageCover.GetComponent<RectTransform>();
            rectTransform.anchoredPosition3D = attractionConfig.headerPosition;
            rectTransform.sizeDelta = attractionConfig.headerSize;

            //star rating
            var starIndex = PlayerPrefs.GetInt(attractionConfig.ID);
            setupStar(starIndex);

        }
        public void OnClickedBack()
        {
            SceneManager.LoadScene("HomeScreen", LoadSceneMode.Single);
        }
        public void OnClickStar(int starIndex)
        {
            PlayerPrefs.SetInt(attractionConfig.ID, starIndex);
            //setup star
            setupStar(starIndex);
        }

        private void setupStar(int starIndex)
        {
            for(int i=0; i<stars.Count;i++)
            {
                stars[i].color = i<starIndex ? activeColor : inactiveColor;
            }
        }
    }
}