using UnityEngine;
using UnityEngine.InputSystem;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem particles;

    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Keyboard.current != null &&
            Keyboard.current.pKey.wasPressedThisFrame)
        {
            Debug.Log("P pressed - emitting particles");

            particles.Emit(50);
        }
    }
}