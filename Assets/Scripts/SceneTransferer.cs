using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneTransferer : MonoBehaviour
    {
        [SerializeField] private string _scene;

        public void Transfer()
        {
            SceneManager.LoadScene(_scene);
        }
    }
}