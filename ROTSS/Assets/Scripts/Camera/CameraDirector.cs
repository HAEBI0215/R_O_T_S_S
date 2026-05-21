using UnityEngine;
using Cinemachine;

public class CameraDirector : MonoBehaviour
{
    [Header("카메라")]
    [SerializeField] private CinemachineVirtualCamera battleCenterCam;
    [SerializeField] private CinemachineVirtualCamera playerFocusCam;

    private CinemachineVirtualCamera[] cameras;

    private void Awake()
    {
        cameras = new[]
        {
            battleCenterCam,
            playerFocusCam,
        };

        SetBattleCenter();
    }

    private void SetActiveCamera(CinemachineVirtualCamera activeCam)
    {
        foreach (var cam in cameras)
        {
            cam.Priority = cam == activeCam ? 100 : 0;
        }
    }

    public void SetBattleCenter()
    {
        SetActiveCamera(battleCenterCam);
    }
    public void SetPlayerFocus()
    {
        SetActiveCamera(playerFocusCam);
    }
}
