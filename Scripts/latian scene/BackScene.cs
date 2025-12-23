using UnityEngine;
using UnityEngine.SceneManagement;
namespace LatianScene
{
    public class BackScene : MonoBehaviour
    {
        public void KembaliScene()
        {
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
    }
}