using UnityEngine;

namespace  MuseumApp
{
    [CreateAssetMenu(fileName = "New Attraction Config", menuName = "Museum/Attraction Config", order = 0)]
    public class AttractionConfig : ScriptableObject
    {
        public string ID;
        public string Title;
        public string Author;
        public string Description;
        public string Location;

        public Sprite Image;

        public Vector2 ThumbnailSize;
        public Vector3 ThumbnailPosition;

        public Vector2 HeaderSize;
        public Vector3 HeaderPosition;
    }
}

