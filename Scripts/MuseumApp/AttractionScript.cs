using System;
using UnityEngine;

namespace MuseumApp
{
    [CreateAssetMenu(fileName = "New Attraction Config", menuName = "MuseumApp/Attraction Config", order = 0)]
    public class AttractionScript : ScriptableObject
    {
        public string ID;
        public string Tittle;
        public string Author;
        public string Description;
        public string Location;
        public Sprite Image; //menampung gambar
        public Vector2 thumbnailSize; //menampung ukuran thumbnail
        public Vector3 thumbnailPosition; //menampung posisi thumbnail

        public Vector2 headerSize; //menampung ukuran header
        public Vector3 headerPosition; //menampung posisi header

        public int starIndex;
    }
}