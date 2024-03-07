using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Transform _respawnPoint;
    [SerializeField] private Cinemachine.CinemachineVirtualCamera _virtualCamera;

    public void RespawnPlayer()
    {
        GameObject player = Instantiate(_playerPrefab, _respawnPoint.position, Quaternion.identity);
        if (player != null)
        {
            _virtualCamera.Follow = player.transform;
        }
    }
}
