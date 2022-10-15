using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PauseHandlerInitializer : MonoBehaviour
{
    [FormerlySerializedAs("_pauseManager")] [SerializeField] private Pause pause;
    [SerializeField] private MoveCharacterController _characterController;
    [SerializeField] private SimplePlayerAttack _simplePlayerAttack;
    [SerializeField] private UltimatePlayerAttack _ultimatePlayerAttack;

    private void Start()
    {
        pause.Register(new GamePauseBehaviour());
        pause.Register(_characterController);
        pause.Register(_simplePlayerAttack);
        pause.Register(_ultimatePlayerAttack);
    }
}
