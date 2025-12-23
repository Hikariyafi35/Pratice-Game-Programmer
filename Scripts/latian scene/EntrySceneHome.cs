using UnityEngine;
using UnityEngine.SceneManagement;

namespace LatianScene
{
    public class EntrySceneHome : MonoBehaviour
    {
        public void PindaScene()
        {
            SceneManager.LoadScene(4, LoadSceneMode.Additive);
        }
    }
}