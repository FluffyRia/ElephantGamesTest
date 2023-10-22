using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneTransferer : MonoBehaviour
    {
        [SerializeField] private SceneAsset _scene;

        public void Transfer()
        {
            SceneManager.LoadScene(_scene.name);
        }
    }
}