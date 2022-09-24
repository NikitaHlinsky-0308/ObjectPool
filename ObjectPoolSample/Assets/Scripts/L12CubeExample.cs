using UnityEngine;

public class L12CubeExample : MonoBehaviour
{

    [SerializeField] private int poolCount = 3;
    [SerializeField] private bool autoExpand = false;
    [SerializeField] private L12Cube cubePrefab;

    private PoolMono<L12Cube> _pool;
    
    private void Start()
    {
        this._pool = new PoolMono<L12Cube>(this.cubePrefab, this.poolCount, this.transform);
        this._pool.autoExpand = this.autoExpand;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.CreateCube();
        }
    }

    private void CreateCube()
    {
        var rX = Random.Range(-5f, 5f);
        var rZ = Random.Range(-5f, 5f);
        var y = 0;

        var rPos = new Vector3(rX, y, rZ);
        var cube = this._pool.GetFreeElement();
        cube.transform.position = rPos;
    }

    
    
}
