using UnityEngine;

namespace MuseumApp
{
    public class AttractionScreenParameters : MonoBehaviour
    {
        public AttractionScript config;
        private void Awake() {
            DontDestroyOnLoad(gameObject);
        }
    }
}