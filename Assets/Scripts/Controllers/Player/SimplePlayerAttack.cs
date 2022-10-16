using UnityEngine;
using UnityEngine.Serialization;

public class SimplePlayerAttack : MonoBehaviour, IPauseHandler
{
    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private Transform _bulletSpawnPosition;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private ScoreCalculator _scoreCalculator;
    private Characteristics _characteristics;

    [SerializeField] private float _attackCooldown = 0.1f;
    private float _nextFireTime = 0f;

    private bool _isPaused;


    private void Start()
    {
        _characteristics = new Characteristics();
    }

    private void Update()
    {
        if (_isPaused)
            return;

        if ((Input.touchCount == 1 || Input.GetMouseButton(0)) && Time.time > _nextFireTime)
        {
            _nextFireTime = Time.time + _attackCooldown;
            Damager damager = Instantiate(_bulletPrefab, _bulletSpawnPosition.position, _bulletSpawnPosition.rotation)
                                         .GetComponent<Damager>();
            damager.SetDamage(_characteristics.Damage);
            damager.OnDeathAction(OnEnemyKilling);

            _audio.Play();
        }
    }

    private void OnEnemyKilling()
    {
        _scoreCalculator.AddScore();
    }

    public void SetPaused(bool isPaused)
    {
        _isPaused = isPaused;
    }
}